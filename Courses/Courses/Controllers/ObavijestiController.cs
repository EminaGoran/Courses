using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Courses.Services.Database;
using Courses.Services;
using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Courses.Controllers;

namespace Courses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObavijestiController : BaseCRUDController<Model.Obavijesti, ObavijestiSearchObject, ObavijestiInsertRequest, ObavijestiUpdateRequest>
    { 
   
        public ObavijestiController(ILogger<BaseController<Model.Obavijesti, ObavijestiSearchObject>> logger, IObavijestiService service) :base(logger,service)
        {
            
        }

  
    } 

        
}