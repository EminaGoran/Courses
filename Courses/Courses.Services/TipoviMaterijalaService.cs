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
   public class TipoviMaterijalaService:BaseCRUDService<Model.TipMaterijala,Database.TipMaterijala, TipMaterijalaSearchObject, TipMaterijalaInsertRequest, TipMaterijalaInsertRequest>,ICRUDService<Model.TipMaterijala, TipMaterijalaSearchObject, TipMaterijalaInsertRequest,TipMaterijalaInsertRequest>
    {
        public TipoviMaterijalaService(CoursesContext context, IMapper mapper) : base(context, mapper)
    {
    }

        public override IQueryable<TipMaterijala> AddInclude(IQueryable<TipMaterijala> query, TipMaterijalaSearchObject? tsearch = null)
        {

            if(tsearch.IsMaterijaliIncluded==true)
            {
                query = query.Include("Materijalis");
            }
            return base.AddInclude(query, tsearch);
        }
    }
}
