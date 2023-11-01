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
    public class GradController : BaseCRUDController<Model.Grad,GradSearchObject, GradInsertRequest, GradInsertRequest>
    {

        public GradController(ILogger<BaseController<Model.Grad, GradSearchObject>> logger, ICRUDService<Model.Grad, GradSearchObject, GradInsertRequest, GradInsertRequest> service) :base(logger,service)
        {
            
        }

      
    } 

        
}