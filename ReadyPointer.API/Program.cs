using Microsoft.OpenApi.Models;
using ReadyPointer.API.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<EndpointsConfig>(builder.Configuration.GetSection("EndpointsConfig"));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ReadyPointer Restful API",
        Version = "v1",
        Description = "An example ASP.NET Core Web API to perform all API operations.",
    });
});

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