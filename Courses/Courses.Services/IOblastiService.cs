using Courses.Model.Request;
using Courses.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
   public interface IOblastiService:ICRUDService<Model.Oblasti,OblastiSearchObject,OblastiInsertRequest,OblastiUpdateRequest>
    {
      
    }
}
