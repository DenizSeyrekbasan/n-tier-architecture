using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

if (true)
{
    foreach (var customer in customerManager.GetAllByCountry("Germany"))
    {
        Console.WriteLine(customer.CustomerId);
    }
}
Console.WriteLine("no data found !");
