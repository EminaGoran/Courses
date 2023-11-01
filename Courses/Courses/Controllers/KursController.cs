using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Courses.Services.Database;
using Courses.Model.Request;
using Courses.Model.SearchObjects;


namespace Courses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KursController : BaseCRUDController<Model.Kurs, KurseviSearchObject,KurseviInsertRequest, KurseviUpdateRequest>

    {
      

        public KursController(IKursService service, ILogger<BaseController<Model.Kurs,KurseviSearchObject>> logger):base(logger,service)
        {
           
        }

    } 

        
}