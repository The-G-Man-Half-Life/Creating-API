using Creating_API.Models;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

Env.Load();

string DB_HOST = Environment.GetEnvironmentVariable("DB_HOST");
string DB_NAME = Environment.GetEnvironmentVariable("DB_NAME");
string DB_USERNAME = Environment.GetEnvironmentVariable("DB_USERNAME");
string DB_PORT = Environment.GetEnvironmentVariable("DB_PORT");
string DB_PASSWORD = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={DB_HOST};port={DB_PORT};database={DB_NAME};uid={DB_USERNAME};password={DB_PASSWORD};";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options=>
options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",new OpenApiInfo {Title = "Creating API",Version = "v1"});
    c.EnableAnnotations();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
