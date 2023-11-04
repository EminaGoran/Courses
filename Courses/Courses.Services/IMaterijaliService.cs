using Courses.Model.Request;
using Courses.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
   public interface IMaterijaliService : ICRUDService<Model.Materijali, MaterijaliSearchObject, MaterijaliInsertRequest, MaterijaliUpdateRequest>
    {
      
    }
}
