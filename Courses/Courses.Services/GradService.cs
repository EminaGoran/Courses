using AutoMapper;
using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Courses.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
    public class GradService : BaseCRUDService<Model.Grad, Gradovi, GradSearchObject, GradInsertRequest, GradInsertRequest>,ICRUDService<Model.Grad, GradSearchObject, GradInsertRequest, GradInsertRequest>
    {
        public GradService(CoursesContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public override IQueryable<Gradovi> AddFilter(IQueryable<Gradovi> query, GradSearchObject? tsearch = null)
        {
            if (!string.IsNullOrWhiteSpace(tsearch.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(tsearch.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(tsearch.PostanskiBroj))
            {
                query = query.Where(x => x.PostanskiBroj==tsearch.PostanskiBroj);
            }


            return base.AddFilter(query, tsearch);
        }

    }
}
