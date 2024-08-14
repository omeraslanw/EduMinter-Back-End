using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICourseDal, CourseDal>();
builder.Services.AddSingleton<ICourseService, CourseManager>();

builder.Services.AddSingleton<ICertificateDal, CertificateDal>();
builder.Services.AddSingleton<ICertificateService, CertificateManager>();

builder.Services.AddSingleton<IUserDal, UserDal>();
builder.Services.AddSingleton<IUserService, UserManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();