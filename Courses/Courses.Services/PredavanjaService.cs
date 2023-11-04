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
    public class PredavanjaServices:BaseCRUDService<Model.Predavanja, Database.Predavanja, PredavanjaSearchObject, PredavanjaInsertRequest, PredavanjaUpdateRequest>, IPredavanjaService
    {

        public PredavanjaServices(CoursesContext context, IMapper mapper):base(context, mapper)
        {
          
        }


   

      

    }
}
