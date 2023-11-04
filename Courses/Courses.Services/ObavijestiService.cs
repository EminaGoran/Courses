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
    public class ObavijestiService:BaseCRUDService<Model.Obavijesti, Database.Obavijesti, ObavijestiSearchObject, ObavijestiInsertRequest, ObavijestiUpdateRequest>, IObavijestiService
    {
        
        public ObavijestiService(CoursesContext context, IMapper mapper):base(context, mapper)
        {
          
        }


   

        public override IQueryable<Obavijesti> AddFilter(IQueryable<Obavijesti> query, ObavijestiSearchObject? tsearch = null)
        {
            if (!string.IsNullOrWhiteSpace(tsearch.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(tsearch.Naziv));
            }
            if (tsearch.TipObavijestiId!=null)
            {
                query = query.Where(x => x.TipObavijestiId==tsearch.TipObavijestiId);
            }
            if ((tsearch.DatumObjave)!=null)
            {
                query = query.Where(x => x.DatumObjave==tsearch.DatumObjave);
            }
        

            return base.AddFilter(query, tsearch);
        }

    }
}
