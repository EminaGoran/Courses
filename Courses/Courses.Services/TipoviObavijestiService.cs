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
   public class TipoviObavijestiService:BaseCRUDService<Model.TipoviObavijesti, TipoviObavijesti, TipoviObavijestiSearchObject, TipoviObavijestiInsertRequest, TipoviObavijestiInsertRequest>,ICRUDService<Model.TipoviObavijesti, TipoviObavijestiSearchObject, TipoviObavijestiInsertRequest,TipoviObavijestiInsertRequest>
    {
        public TipoviObavijestiService(CoursesContext context, IMapper mapper) : base(context, mapper)
    {
    }

        public override IQueryable<TipoviObavijesti> AddInclude(IQueryable<TipoviObavijesti> query, TipoviObavijestiSearchObject? tsearch = null)
        {

            if(tsearch.IsObavijestiIncluded==true)
            {
                query = query.Include("Obavijestis");
            }
            return base.AddInclude(query, tsearch);
        }
    }
}
