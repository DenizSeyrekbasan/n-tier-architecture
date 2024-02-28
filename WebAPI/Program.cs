using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

//Autofac Configuration - we use autofac IoC container
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(
   builder => builder.RegisterModule(new AutofacBusinessModule()));



// Add services to the container.

builder.Services.AddControllers();

//IoC Container
//Arka planda bizim yerimize newleme islemi
//builder.Services.AddSingleton<IProductService, ProductManager>();//icerisinde data yoksa AddSingleton kullan
//builder.Services.AddSingleton<IProductDal, EfProductDal>();

//builder.Services.AddSingleton<IOrderService, OrderManager>();
//builder.Services.AddSingleton<IOrderDal, EfOrderDal>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
