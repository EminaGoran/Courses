using Courses;
using Courses.Controllers;
using Courses.Model;
using Courses.Model.SearchObjects;
using Courses.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.OpenApi.Writers;

namespace Courses.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class BaseCRUDController<T, Tsearch,Tinsert,Tupdate> : BaseController<T, Tsearch> where T: class where Tsearch : class
    {
        protected new readonly ICRUDService<T, Tsearch,Tinsert,Tupdate> _service;
        protected  readonly ILogger<BaseController<T, Tsearch>> _logger;
        private ILogger<BaseController<Drzave, BaseSearchObject>> logger;
        private IService<Drzave, BaseSearchObject> service;

        public BaseCRUDController(ILogger<BaseController<T, Tsearch>> logger, ICRUDService<T, Tsearch,Tinsert,Tupdate> service) : base(logger, service)
        {
            _logger = logger;
            _service = service;
        }

    
        [HttpPost]
        [Authorize (Roles ="Administrator")]
        public virtual async Task<T> Insert ([FromBody]Tinsert insert)
        {
            return await _service.Insert(insert);
        }

        [HttpPut("{id}")]
        public virtual async Task<T> Update(int id, [FromBody] Tupdate update)
        {
            return await _service.Update(id, update);
        }

        [HttpDelete("{id}")]
        public virtual async Task<T> Delete(int id)
        {
            return await _service.Delete(id);
        
        }
    }
}
