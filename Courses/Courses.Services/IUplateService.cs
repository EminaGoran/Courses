using Courses.Model.Request;
using Courses.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
   public interface IUplateService:ICRUDService<Model.Uplate,UplateSearchObject,UplateInsertRequest,UplateUpdateRequest>
    {
      
    }
}
