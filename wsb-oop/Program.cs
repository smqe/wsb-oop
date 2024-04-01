using Microsoft.EntityFrameworkCore;
using wsb_oop.Product.db;
using wsb_oop.Product.mappers;
using wsb_oop.Product.services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddControllers();
services.AddScoped<IProductService, ProductService>();
services.AddScoped<ProductMapper>();
services.AddDbContext<ProductDbContext>(options=>
    options.UseSqlite("Data Source=Product.sqlite")
);

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ProductDbContext>();
    db.Database.Migrate();
}
app.UseHttpsRedirection();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
