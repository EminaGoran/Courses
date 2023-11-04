using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Courses.Services.Database;
using Courses.Services;
using Courses.Model.Request;
using Microsoft.EntityFrameworkCore.Storage;
using Courses.Model.SearchObjects;


namespace Courses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoviObavijestiController : BaseCRUDController<Model.TipoviObavijesti, TipoviObavijestiSearchObject, TipoviObavijestiInsertRequest, TipoviObavijestiInsertRequest>
    {

        public TipoviObavijestiController(ILogger<BaseController<Model.TipoviObavijesti, TipoviObavijestiSearchObject>> logger, ICRUDService<Model.TipoviObavijesti, TipoviObavijestiSearchObject, TipoviObavijestiInsertRequest, TipoviObavijestiInsertRequest> service) :base(logger,service)
        {
            
        }

      
    } 

        
}