using Examveda.Configuration;
using Examveda.Repository;
using Examveda.Service;
using ExamVedaApp.Models;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<MongoDbConfiguration>(builder.Configuration.GetSection("Database"));

builder.Services.AddSingleton(options =>
{
    var mongoSettings = builder.Configuration.GetSection("Database").Get<MongoDbConfiguration>();
    var client = new MongoClient(mongoSettings.ConnectionString);
    return client.GetDatabase(mongoSettings.DatabaseName);
});

//services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();

//repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
builder.Services.AddScoped<IQuestionsRepository, QuestionsRepository>();

builder.Services.AddAutoMapper(typeof(Program));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
