using Microsoft.OpenApi.Models;
using pcp.payments.boundedContext.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {

        Title = "Microserviço WebApi RestFul",
        Version = "v1",
        Description = "Microserviços desenvolvido pra gerenciamento de Pagamentos.",
        Contact = new OpenApiContact()
        {
            Name = "Edson Rodrigo",
            Url = new Uri("https://microservicopagamentos.com.br/"),
            Email = "edson@edson.com",
        }
    });
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,
    $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));


});
builder.Services.ResolveDependencies();
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
