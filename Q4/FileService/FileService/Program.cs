using FileService.BlobService;
using FileService.DbService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext to interact with SQLServer
builder.Services.AddDbContext<FileService.DbContext.DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Azure Blob Storage Service
builder.Services.AddScoped<IBlobService, BlobService>();

// Add Db service.
// !!!! IMPORTANT the DbService has been declared using an specific entity as generic type
// But this should be a base abstract class to be inherited for specific ones in order to make the code more flexible.
builder.Services.AddScoped<IDbService<FileService.Entities.File>, DbService<FileService.Entities.File>>();

var app = builder.Build();

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
