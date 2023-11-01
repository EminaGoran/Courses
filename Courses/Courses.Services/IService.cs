using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Model;
using Courses.Model.Request;

namespace Courses.Services
{
   public interface IService<T,Tsearch>where T : class  where Tsearch : class
    {
        Task<PageResult<T>> Get(Tsearch search=null);
        Task<T> GetById(int id);
    }
}
