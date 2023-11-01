using Courses.Model.Request;
using Courses.Model.SearchObjects;
using Courses.Services;
using Courses.Services.Database;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IKursService, KursService>();
builder.Services.AddTransient<IKorisniciService, KorisniciService>();
builder.Services.AddTransient<IOblastiService, OblastiServices>();
builder.Services.AddTransient<ICRUDService<Courses.Model.Drzave, DrzaveSearchObject, DrzaveInsertRequest, DrzaveInsertRequest>, DrzaveServices>();
//builder.Services.AddTransient<IService<Courses.Model.Drzave,BaseSearchObject>, BaseService<Courses.Model.Drzave,Courses.Services.Database.Drzave,BaseSearchObject>>();


builder.Services.AddTransient<ICRUDService<Courses.Model.Grad, GradSearchObject, GradInsertRequest, GradInsertRequest>,GradService> ();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CoursesContext>(options => options.UseSqlServer(connectionString)
);


builder.Services.AddAutoMapper(typeof(IKorisniciService));
builder.Services.AddAutoMapper(typeof(IKursService));
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
