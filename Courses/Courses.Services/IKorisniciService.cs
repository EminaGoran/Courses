using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Courses.Model.Request;
using Courses.Model.SearchObjects;

namespace Courses.Services
{
    public interface IKorisniciService : ICRUDService<Model.Korisnici, KorisniciSearchObject,KorisniciInsertRequest,KorisniciUpdateRequest>
    {
        public Task<Model.Korisnici> Login(string username, string password);

    }
}
