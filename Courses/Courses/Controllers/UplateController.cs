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
    public class UplateController : BaseCRUDController<Model.Uplate, UplateSearchObject, UplateInsertRequest, UplateUpdateRequest>
    { 
   
        public UplateController(ILogger<BaseController<Model.Uplate, UplateSearchObject>> logger, IUplateService service) :base(logger,service)
        {
            
        }

  
    } 

        
}