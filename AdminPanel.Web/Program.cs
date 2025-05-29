using AdminPanel.Application;
using AdminPanel.Web.Common.Extensions;
using AdminPanel.Web.Common.Middlewares;
using Infrastructure.Persistance;
using Microsoft.AspNetCore.Http.Features;
using Services.Services.JwtService.Extensions;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAdminApplication(builder.Configuration);
builder.Services.AddAdminApplicationPersistence(builder.Configuration);
builder.Services.AddSwaggerServices();
builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddAuthorizationAuthetication();
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 999_000_000;
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();


builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseSwaggerApps();
app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseAdminApplicationMigrates();

app.Run();
