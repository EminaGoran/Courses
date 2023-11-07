﻿using Courses.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Data;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace Courses
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        IKorisniciService _korisniciService;
        public BasicAuthenticationHandler(IKorisniciService korisniciService, IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            _korisniciService = korisniciService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing header");
            }
            var autHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var credentialsByte = Convert.FromBase64String(autHeader.Parameter);
            var credentials = Encoding.UTF8.GetString(credentialsByte).Split(':');

            var username = credentials[0];
            var lozinka = credentials[1];

            var user = await _korisniciService.Login(username, lozinka);

            if (user == null)
            {
                return AuthenticateResult.Fail("Nesipravan username ili lozinka");
            }



            else
            {

                //lista osobina korisinika -claims
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.Ime),
                    new Claim(ClaimTypes.NameIdentifier,user.KorisnickoIme),


                    new Claim(ClaimTypes.Role,user.UlogaNavigation.Naziv)


            };


                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }

        }
    }
}








