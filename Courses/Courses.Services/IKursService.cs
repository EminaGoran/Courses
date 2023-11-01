using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
     public  interface IKursService:ICRUDService<Model.Kurs,KurseviSearchObject,KurseviInsertRequest,KurseviUpdateRequest>
    {
       

    }
}
