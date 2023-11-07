using Courses;
using Courses.Filters;
using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Courses.Services;
using Courses.Services.Database;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IKursService, KursService>();
builder.Services.AddTransient<IKorisniciService, KorisniciService>();
builder.Services.AddTransient<IOblastiService, OblastiServices>();
builder.Services.AddTransient<IObavijestiService, ObavijestiService>();
builder.Services.AddTransient<IMaterijaliService, MaterijaliServices>();
builder.Services.AddTransient<IUplateService,UplateServices>();
builder.Services.AddTransient<IPredavanjaService, PredavanjaServices>();
builder.Services.AddTransient<ICRUDService<Courses.Model.Drzave, DrzaveSearchObject, DrzaveInsertRequest, DrzaveInsertRequest>, DrzaveServices>();
//builder.Services.AddTransient<IService<Courses.Model.Drzave,BaseSearchObject>, BaseService<Courses.Model.Drzave,Courses.Services.Database.Drzave,BaseSearchObject>>();


builder.Services.AddTransient<ICRUDService<Courses.Model.Grad, GradSearchObject, GradInsertRequest, GradInsertRequest>,GradService> ();
builder.Services.AddTransient<ICRUDService<Courses.Model.TipoviObavijesti, TipoviObavijestiSearchObject, TipoviObavijestiInsertRequest, TipoviObavijestiInsertRequest>, TipoviObavijestiService>();
builder.Services.AddTransient<ICRUDService<Courses.Model.TipMaterijala, TipMaterijalaSearchObject, TipMaterijalaInsertRequest, TipMaterijalaInsertRequest>, TipoviMaterijalaService>();


builder.Services.AddControllers( x=> { x.Filters.Add<ErrorFilter>(); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
{
    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
    Scheme = "basic"
});

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {

    new OpenApiSecurityScheme
    {
    Reference=new OpenApiReference{Type=ReferenceType.SecurityScheme, Id="basicAuth"}
    },
    new string[] {}
    } });

     }) ;


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CoursesContext>(options => options.UseSqlServer(connectionString)
);


builder.Services.AddAutoMapper(typeof(IKorisniciService));
builder.Services.AddAutoMapper(typeof(IKursService));
builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication",null);
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();


app.MapControllers();

app.Run();
