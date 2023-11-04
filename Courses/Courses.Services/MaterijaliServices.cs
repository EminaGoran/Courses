using AutoMapper;
using Courses.Model;
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
    public class MaterijaliServices:BaseCRUDService<Model.Materijali, Database.Materijali, MaterijaliSearchObject, MaterijaliInsertRequest, MaterijaliUpdateRequest>, IMaterijaliService
    {
        
        public MaterijaliServices(CoursesContext context, IMapper mapper):base(context, mapper)
        {
          
        }


   

    }
}
