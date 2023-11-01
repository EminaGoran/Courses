using AutoMapper;
using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Courses.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
    public class OblastiServices:BaseCRUDService<Model.Oblasti,Database.Oblasti,OblastiSearchObject,OblastiInsertRequest,OblastiUpdateRequest>, IOblastiService
    {
        
        public OblastiServices(CoursesContext context, IMapper mapper):base(context, mapper)
        {
          
        }


   

        public override IQueryable<Oblasti> AddFilter(IQueryable<Oblasti> query, OblastiSearchObject? tsearch = null)
        {
            if (!string.IsNullOrWhiteSpace(tsearch.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(tsearch.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(tsearch.FTS))
            {
                query = query.Where(x => x.Naziv.Contains(tsearch.FTS));
            }
        

            return base.AddFilter(query, tsearch);
        }

    }
}
