using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Courses.Services.Database;
using Courses.Model.Request;
using Courses.Model.SearchObjects;


namespace Courses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterijaliController : BaseCRUDController<Model.Materijali, MaterijaliSearchObject, MaterijaliInsertRequest, MaterijaliUpdateRequest>
    {

        public MaterijaliController( IMaterijaliService service, ILogger<BaseController<Model.Materijali, MaterijaliSearchObject>> logger):base(logger,service)
        {
       
        }

      

  
    } 

        
}