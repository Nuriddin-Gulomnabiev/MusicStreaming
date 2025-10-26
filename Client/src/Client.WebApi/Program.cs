using Client.Application;
using Client.WebApi.Common.Extensions;
using Client.WebApi.Common.Middlewares;
using Infrastructure.Persistance;
using Services.Services.JwtService.Extensions;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddClientApplication(builder.Configuration);
builder.Services.AddClientApplicationPersistence(builder.Configuration);
builder.Services.AddSwaggerServices();
builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddAuthorizationAuthetication();

var app = builder.Build();

builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseSwaggerApps();
app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();