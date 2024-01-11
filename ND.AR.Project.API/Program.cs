using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ND.AR.Project.API.Authorazation;
using ND.AR.Project.DA;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Add Swagger services
builder.Services.AddSwaggerGen(Options =>
{
    Options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title ="ND.AR.Project.API",
        Version = "v1",
        Description = "ND.AR.Project.API"
    });
});

var app = builder.Build();

// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();
app.UseMiddleware<JWTAuthourazation>();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ND.AR>Project");
});

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
