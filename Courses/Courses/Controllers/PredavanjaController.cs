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
    public class PredavanjaController : BaseCRUDController<Model.Predavanja, PredavanjaSearchObject, PredavanjaInsertRequest, PredavanjaUpdateRequest>
    { 
   
        public PredavanjaController(ILogger<BaseController<Model.Predavanja, PredavanjaSearchObject>> logger, IPredavanjaService service) :base(logger,service)
        {
            
        }

  
    } 

        
}