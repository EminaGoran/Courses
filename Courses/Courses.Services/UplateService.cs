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
    public class UplateServices:BaseCRUDService<Model.Uplate, Database.Uplate, UplateSearchObject, UplateInsertRequest, UplateUpdateRequest>, IUplateService
    {

        public UplateServices(CoursesContext context, IMapper mapper):base(context, mapper)
        {
          
        }


   

        public override IQueryable<Uplate> AddFilter(IQueryable<Uplate> query, UplateSearchObject? tsearch = null)
        {
            if (tsearch.KursId!=null)
            {
                query = query.Where(x => x.KursId==tsearch.KursId);
            }
            if (tsearch.KorisnikId != null)
            {
                query = query.Where(x => x.KorisnikId == tsearch.KorisnikId);
            }

            return base.AddFilter(query, tsearch);
        }


        public override IQueryable<Uplate> AddInclude(IQueryable<Uplate> query, UplateSearchObject? tsearch = null)
        {
            if (tsearch?.IsKorisniciInclude== true)
            {


                query = query.Include("Korisnik.Uplates");

            }

            if (tsearch?.IsKursInclude == true)
            {


                query = query.Include("Kurs.Uplates");

            }

            return base.AddInclude(query, tsearch);
        }


        
    }

}

