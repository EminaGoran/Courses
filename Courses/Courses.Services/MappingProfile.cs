using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Courses.Services
{
   public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Kursevi, Model.Kurs>();
            CreateMap<Model.Request.KorisniciInsertRequest, Database.Korisnici>();
            CreateMap<Model.Request.KorisniciUpdateRequest, Database.Korisnici>();
            CreateMap<Database.Oblasti, Model.Oblasti>();
            CreateMap<Model.Request.OblastiInsertRequest, Database.Oblasti>();
            CreateMap<Model.Request.OblastiUpdateRequest, Database.Oblasti>();
            CreateMap<Database.Drzave, Model.Drzave>();
            CreateMap<Model.Request.DrzaveInsertRequest, Database.Drzave>();
            CreateMap<Database.Gradovi, Model.Grad>();
            CreateMap<Model.Request.GradInsertRequest, Database.Gradovi>();
            CreateMap<Database.Uloga, Model.Uloga>();
    
            CreateMap<Model.Request.KurseviInsertRequest, Database.Kursevi>();
            CreateMap<Model.Request.KurseviUpdateRequest, Database.Kursevi>();
            CreateMap<Database.KursKorisnici, Model.KursKorisnici>();

        }
    }
}
