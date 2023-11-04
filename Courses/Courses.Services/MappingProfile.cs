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

            CreateMap<Database.Obavijesti, Model.Obavijesti>();
            CreateMap<Model.Request.ObavijestiInsertRequest,Database.Obavijesti>();
            CreateMap<Model.Request.ObavijestiUpdateRequest,Database.Obavijesti>();

            CreateMap<Database.TipoviObavijesti, Model.TipoviObavijesti>();
            CreateMap<Model.Request.TipoviObavijestiInsertRequest, Database.TipoviObavijesti>();

            CreateMap<Database.TipMaterijala, Model.TipMaterijala>();
            CreateMap<Model.Request.TipMaterijalaInsertRequest, Database.TipMaterijala>();

            CreateMap<Database.Materijali, Model.Materijali>();
            CreateMap<Model.Request.MaterijaliInsertRequest, Database.Materijali>();
            CreateMap<Model.Request.MaterijaliUpdateRequest, Database.Materijali>();

            CreateMap<Database.Uplate, Model.Uplate>();
            CreateMap<Model.Request.UplateInsertRequest, Database.Uplate>();
            CreateMap<Model.Request.UplateUpdateRequest, Database.Uplate>();

            CreateMap<Database.Predavanja, Model.Predavanja>();
            CreateMap<Model.Request.PredavanjaInsertRequest, Database.Predavanja>();
            CreateMap<Model.Request.PredavanjaUpdateRequest, Database.Predavanja>();


        }
    }
}
