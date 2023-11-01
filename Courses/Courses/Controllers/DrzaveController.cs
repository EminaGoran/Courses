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
    public class DrzaveController : BaseCRUDController<Model.Drzave,DrzaveSearchObject,DrzaveInsertRequest,DrzaveInsertRequest>
    {

        public DrzaveController(ILogger<BaseController<Model.Drzave,DrzaveSearchObject>> logger, ICRUDService<Model.Drzave, DrzaveSearchObject, DrzaveInsertRequest, DrzaveInsertRequest> service) :base(logger,service)
        {
            
        }

      
    } 

        
}