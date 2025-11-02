using AdminPanel.Application;
using AdminPanel.WebApi.Common.Extensions;
using AdminPanel.WebApi.Common.Middlewares;
using Infrastructure.Persistance;
using Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
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

var app = builder.Build();

builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseSwaggerApps();
app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AdminApplicationDbContext>();

    db.Database.Migrate();
}

app.Run();
