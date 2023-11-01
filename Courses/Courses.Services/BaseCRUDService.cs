using AutoMapper;
using Courses.Model.SearchObjects;
using Courses.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
    public class BaseCRUDService<T, Tdb, Tsearch, Tinsert, Tupdate> : BaseService<T, Tdb, Tsearch> where Tsearch : BaseSearchObject where Tdb : class where T : class where Tinsert : class where Tupdate : class
    {
        public BaseCRUDService(CoursesContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public virtual async Task BeforeInsert(Tdb db, Tinsert insert)
        {

        }

        public virtual async Task<T> Insert(Tinsert insert)
        {
            var set = _context.Set<Tdb>();
            Tdb entity = _mapper.Map<Tdb>(insert);
            set.Add(entity);
            await BeforeInsert(entity, insert);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);

        }

        public virtual async Task<T> Update(int id, Tupdate update)
        {
            var set = _context.Set<Tdb>();
            var entity = await set.FindAsync(id);
            _mapper.Map(update, entity);

            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);

        }

        public virtual async Task<T> Delete(int id)
        {
            var set = _context.Set<Tdb>();
            var entity = await set.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            var x = entity;
            _context.Set<Tdb>().Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<T>(x);
        }
    }
}
