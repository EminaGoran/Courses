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
    public class OblastiController : BaseCRUDController<Model.Oblasti,OblastiSearchObject, OblastiInsertRequest,OblastiUpdateRequest>
    { 
   
        public OblastiController(ILogger<BaseController<Model.Oblasti,OblastiSearchObject>> logger, IOblastiService  service) :base(logger,service)
        {
            
        }

  
    } 

        
}