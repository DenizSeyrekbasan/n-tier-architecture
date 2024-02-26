using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.Linq.Expressions;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var item in productManager.GetProductDetails())
{
    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
}