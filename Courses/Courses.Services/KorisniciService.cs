using AutoMapper;
using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Courses.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Courses.Services
{
    public class KorisniciService : BaseCRUDService<Model.Korisnici, Database.Korisnici, KorisniciSearchObject,KorisniciInsertRequest,KorisniciUpdateRequest>, IKorisniciService
    {


        public KorisniciService(CoursesContext context, IMapper mapper) : base(context, mapper)
        {

        }


      

        public override async Task BeforeInsert(Korisnici entity, KorisniciInsertRequest request)
        {
            //entity.DatumRegistracije = DateTime.Now;
            //entity.DatumPosljednjePrijave = DateTime.Now;

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
         

        }

      
   


        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);


            return Convert.ToBase64String(byteArray);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override  IQueryable<Korisnici> AddInclude(IQueryable<Korisnici> query, KorisniciSearchObject? tsearch = null)
        {
            if (tsearch?.IsUlogaIncluded == true)
            {

            
                query = query.Include("UlogaNavigation.Korisnicis");

            }
            if (tsearch?.IsKursIncluded == true)
            {

                query = query.Include("KursKorisnicis.Kurs");
              

            }
            return base.AddInclude(query, tsearch);
            }
        }
    }


