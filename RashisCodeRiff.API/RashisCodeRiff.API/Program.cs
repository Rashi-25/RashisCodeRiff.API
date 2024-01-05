using Microsoft.EntityFrameworkCore;
using RashisCodeRiff.API.Data;
using RashisCodeRiff.API.Repositories.Implementation;
using RashisCodeRiff.API.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RashiCodeRiffConnectionString"));
});
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200");
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
}
);

app.UseAuthorization();

app.MapControllers();

app.Run();
