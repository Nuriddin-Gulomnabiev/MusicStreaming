using AdminPanel.Application;
using AdminPanel.Web.Common.Middlewares;
using Infrastructure.Persistance;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAdminApplication();
builder.Services.AddAdminApplicationPersistence(builder.Configuration);

/*builder.Services.AddMvc()
                .AddJsonOptions(options => {
                    options.JsonSerializerOptions.DefaultIgnoreCondition
                          = JsonIgnoreCondition.WhenWritingNull;
                });*/

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.Run();
