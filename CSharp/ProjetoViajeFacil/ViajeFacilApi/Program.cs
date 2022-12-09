using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using ViajeFacil.Dominio.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes =>
{
    opcoes.SwaggerDoc("v1", new OpenApiInfo()
    {
        Version = "v1",
        Title = "Viaje Fácil",
        Description = "Api criada afins de facilitar que instituições criem e gerenciem eventos que envolvam viagens, ou excursões, e ajudar os usuários do sistema a encontrar e participar destes eventos.",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
    var filePath = Path.Combine(builder.Environment.ContentRootPath, @"Documents\ViajeFacilApi.xml");
    opcoes.IncludeXmlComments(filePath);
});

string str = builder.Configuration.GetConnectionString("ViajeFacilDB");
builder.Services.AddDbContext<ViajeFacilContexto>(options => options.UseSqlServer(str));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opcoes => opcoes.DocExpansion(DocExpansion.None)); // DocExpansion.None faz com que os verbos http permaneçam fechados ao executar a API.
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
