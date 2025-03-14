using Microsoft.EntityFrameworkCore;
using ShopApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));




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
