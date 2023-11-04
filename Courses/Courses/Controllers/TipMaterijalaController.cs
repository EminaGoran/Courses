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
    public class TipMaterijalaController : BaseCRUDController<Model.TipMaterijala, TipMaterijalaSearchObject, TipMaterijalaInsertRequest, TipMaterijalaInsertRequest>
    {

        public TipMaterijalaController(ILogger<BaseController<Model.TipMaterijala, TipMaterijalaSearchObject>> logger, ICRUDService<Model.TipMaterijala, TipMaterijalaSearchObject, TipMaterijalaInsertRequest, TipMaterijalaInsertRequest> service) :base(logger,service)
        {
            
        }

      
    } 

        
}