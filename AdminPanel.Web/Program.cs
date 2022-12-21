using AdminPanel.Application;
using AdminPanel.Web.Common.Extensions;
using AdminPanel.Web.Common.Middlewares;
using Infrastructure.Persistance;
using Services.Services.JwtService.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAdminApplication(builder.Configuration);
builder.Services.AddAdminApplicationPersistence(builder.Configuration);
builder.Services.AddSwaggerServices();
builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddAuthorizationAuthetication();

var app = builder.Build();


builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseSwaggerApps();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.Run();
