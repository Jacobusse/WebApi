using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using System.Text.Json.Serialization;
using WebApi.Helpers;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args); 

var services = builder.Services;
var env = builder.Environment;

// add services to DI container
services.Configure<WebApiDbSettings>(builder.Configuration.GetSection("WebApiDb"));
services.AddCors();
services.AddControllers().AddJsonOptions(x => {
    // serialize enums as strings in api responses (e.g. Role)
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

    // ignore omitted parameters on models to enable optional params (e.g. User update)
    x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

services.AddSwaggerGen();

// Configure DI for application services
services.AddSingleton<IContactService, ContactService>();

var app = builder.Build();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

// global cors policy
app.UseCors(x => x.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader());

// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();

app.MapControllers();

var pack = new ConventionPack() { new EnumRepresentationConvention(BsonType.String) };
ConventionRegistry.Register("EnumStringConvention", pack, _ => true);

app.Run("http://localhost:4000");