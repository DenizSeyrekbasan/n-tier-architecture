using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IDataResult<List<Order>> EmployeeID(int id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.EmployeeID == id));
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetAllByEmployeeID(int id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.EmployeeID == id));
        }

        public IDataResult<List<Order>> GetAllByShipVia(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.ShipVia >= min && p.ShipVia <= max));
        }

    }
}
