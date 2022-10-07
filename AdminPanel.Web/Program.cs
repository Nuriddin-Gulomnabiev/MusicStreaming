using AdminPanel.Application;
using Infrastructure.Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAdminApplication();
builder.Services.AddAdminApplicationPersistence(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

builder.Configuration.SetBasePath(app.Environment.ContentRootPath);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
