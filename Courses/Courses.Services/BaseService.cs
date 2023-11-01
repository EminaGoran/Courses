using AutoMapper;
using Courses.Model;
using Courses.Model.SearchObjects;
using Courses.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
   public class BaseService<T,Tdb,Tsearch>: IService<T,Tsearch> where Tdb : class where T : class where Tsearch:BaseSearchObject
    {
      protected  CoursesContext _context;
  protected IMapper _mapper { get; set; }
        public BaseService(CoursesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual async Task<PageResult<T>> Get(Tsearch? tsearch=null)
        {
            var query = _context.Set<Tdb>().AsQueryable();
            PageResult<T> result = new PageResult<T>();
          
            query =AddFilter(query,tsearch);
            query = AddInclude(query, tsearch);

            result.Count = await query.CountAsync();
            if (tsearch.Page.HasValue==true && tsearch.PageSize.HasValue==true)
            {
                query=query.Take(tsearch.PageSize.Value).Skip(tsearch.Page.Value*tsearch.PageSize.Value);
            }
            
            var list = await query.ToListAsync();
            
            var tmp= _mapper.Map<List<T>>(list);
            result.Result = tmp;
            return result;


        }

        public virtual IQueryable<Tdb> AddInclude(IQueryable<Tdb> query, Tsearch? tsearch = null)
        {
            return query;

        }
        public virtual IQueryable<Tdb> AddFilter(IQueryable<Tdb> query, Tsearch? tsearch=null)
        {
            return query;

        }
        
        public virtual async Task<T>  GetById(int id)
        {
            var query = await _context.Set<Tdb>().FindAsync(id);
         

            return _mapper.Map<T>(query);

        }
    }
}
