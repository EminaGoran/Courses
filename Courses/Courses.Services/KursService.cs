using Courses.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Model;
using Courses.Model.SearchObjects;
using Courses.Model.Request;
using AutoMapper;

namespace Courses.Services
{
    public class KursService : BaseCRUDService<Model.Kurs, Database.Kursevi, KurseviSearchObject, KurseviInsertRequest, KurseviUpdateRequest>,IKursService
    {
        public KursService(CoursesContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Kursevi> AddFilter(IQueryable<Database.Kursevi> query, KurseviSearchObject? tsearch = null)
        {
            if (!string.IsNullOrWhiteSpace(tsearch.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(tsearch.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(tsearch.Opis))
            {
                query = query.Where(x => x.Naziv.Contains(tsearch.Opis));
            }

                 return base.AddFilter(query, tsearch);
        }

    }
}
