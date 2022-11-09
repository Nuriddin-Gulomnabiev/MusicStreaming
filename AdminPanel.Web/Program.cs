using AdminPanel.Application;
using AdminPanel.Web.Common.Extensions;
using AdminPanel.Web.Common.Middlewares;
using Infrastructure.Persistance;
using Services.Services.FileManager.Extensions;
using Services.Services.IdentifiedService.Extensions;
using Services.Services.JwtService.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAdminApplication();
builder.Services.AddAdminApplicationPersistence(builder.Configuration);
builder.Services.AddSwaggerServices();
builder.Services.AddFileManagerServices(builder.Configuration);
builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddAuthorizationAuthetication();
builder.Services.AddIdentifiedServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
