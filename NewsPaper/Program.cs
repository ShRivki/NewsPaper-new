using ManagingANewspaper;
using ManagingANewspaper.mappings;
using ManagingANewspaper.MiddleWare;
using Microsoft.Extensions.DependencyInjection;
using Solid.Core;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data.Repositories;
using Solid.Service.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IDesignerRepository, DesignerRepository>();
builder.Services.AddScoped<IEditorRepository, EditorRepository>();
builder.Services.AddScoped<IWriterRepository, WriterRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IDesignerService, DesignrService>();
builder.Services.AddScoped<IEditorService, EditorService>();
builder.Services.AddScoped<IWriterService, WriterService>();
builder.Services.AddScoped<IArticleService, ArticleService>();


builder.Services.AddAutoMapper( typeof (ApiMappingProfile), typeof(CoreMappingProfile) );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseTrack();

app.MapControllers();

app.Run();
