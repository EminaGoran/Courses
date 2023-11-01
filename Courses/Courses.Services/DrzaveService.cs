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
    //,ICRUDService<Model.Drzave,DrzaveSearchObject,DrzaveInsertRequest,DrzaveInsertRequest>
    public class DrzaveServices :BaseCRUDService<Model.Drzave,Database.Drzave,DrzaveSearchObject,DrzaveInsertRequest,DrzaveInsertRequest>,ICRUDService<Model.Drzave, DrzaveSearchObject, DrzaveInsertRequest, DrzaveInsertRequest>
    {
        
        public DrzaveServices(CoursesContext context, IMapper mapper):base(context, mapper)
        {
          
        }


   

        

    }
}
