using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Courses.Services.Database;
using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Microsoft.AspNetCore.Authorization;

namespace Courses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : BaseCRUDController<Model.Korisnici,KorisniciSearchObject,KorisniciInsertRequest,KorisniciUpdateRequest>
    {

        public KorisniciController(IKorisniciService service, ILogger<BaseController<Model.Korisnici,KorisniciSearchObject>> logger):base(logger,service)
        {
       
        }

        [Authorize (Roles ="Administrator")]
        public override Task<Model.Korisnici> Insert([FromBody] KorisniciInsertRequest insert)
        {
            return base.Insert(insert);
        }


    } 

        
}