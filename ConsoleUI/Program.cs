using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;


ProductManager productManager = new ProductManager(new EfProductDal());

var result = productManager.GetProductDetails();

if (result.Success)
{
    foreach (var item in result.Data)
    {
        Console.WriteLine(item.ProductName + "/" + item.CategoryName);
    }
}

else
{
    Console.WriteLine(result.Message);
}