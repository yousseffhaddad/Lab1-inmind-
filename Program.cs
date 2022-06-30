using Microsoft.OpenApi.Models;
using WebApplication1.abstraction;
using WebApplication1.Filter;
using WebApplication1.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddTransient<IStudentHelper, StudentHelper1>();
builder.Services.AddTransient<IImageHelper, ImageHelper>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sample.FileUpload.Api", Version = "v1" });
    c.OperationFilter<SwaggerFileOperationFilter>();
});
var app = builder.Build();
app.UseStaticFiles();
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