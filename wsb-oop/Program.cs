using Microsoft.EntityFrameworkCore;
using wsb_oop.Product.db;
using wsb_oop.Product.services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddControllers();
services.AddScoped<IProductService, ProductService>();
services.AddDbContext<ProductDbContext>(options=>
    options.UseSqlite("Data Source=Product.db")
    );

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();
