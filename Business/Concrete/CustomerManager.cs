using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>> (_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetAllByContactTitle(string contactTitle)
        {
            return new SuccessDataResult<List<Customer>> (_customerDal.GetAll(p => p.ContactTitle == contactTitle));
        }

        public IDataResult<List<Customer>> GetAllByCountry(string country)
        {
            return new SuccessDataResult<List<Customer>> (_customerDal.GetAll(p => p.Country == country));
        }
    }
}
