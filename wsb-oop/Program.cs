// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();


// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

using Microsoft.EntityFrameworkCore;
using wsb_oop.Product.db;
using wsb_oop.Product.services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddDbContext<ProductDbContext>(options=>
    options.UseSqlite("Data Source=Product.db")
    );

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
