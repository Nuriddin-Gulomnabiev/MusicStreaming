using FileManager.Application;
using FileManager.WebApi.Common.Middlewares;
using Infrastructure.Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFileManagerPersistence(builder.Configuration);
builder.Services.AddFileManagerApplication(builder.Configuration, builder.Environment.WebRootPath);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.Run();
