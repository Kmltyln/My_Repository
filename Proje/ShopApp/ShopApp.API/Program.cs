using Microsoft.EntityFrameworkCore;
using ShopApp.Data;
using ShopApp.Data.Abstract;
using ShopApp.Data.Concrete.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
StatusCodes.Status400BadRequest;

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();//wwwroot klasörünü kullanıma açar
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
