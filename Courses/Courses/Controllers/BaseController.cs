using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Courses.Services.Database;
using Courses.Model.Request;
using Microsoft.AspNetCore.Mvc;
using Courses.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Courses.Model;

namespace Courses.Controllers
{
    [Route("[controller]")]
   
    public class BaseController<T,Tsearch> : ControllerBase where T : class where Tsearch : class
    {
        protected readonly IService<T,Tsearch> _service;
        protected readonly ILogger<BaseController<T,Tsearch>> _logger;

        public BaseController(ILogger<BaseController<T,Tsearch>> logger, IService<T,Tsearch> service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]

        public async Task<PageResult<T>> Get([FromQuery]Tsearch? search=null)
        {
            return await _service.Get(search);
        }

        [HttpGet("{id}")]

        public async Task<T> GetById(int id)
        {
            return await _service.GetById(id);
        }

        //[HttpPost]
        //public Model.Korisnici Insert(KorisniciInsertRequest request)
        //{
        //    return _korisniciService.Insert(request);   
        //}

        //[HttpPut("{id}")]

        //public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        //{
        //    return _korisniciService.Update(id, request);
        //}
    } 

        
}