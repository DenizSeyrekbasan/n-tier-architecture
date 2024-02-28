using Business.Abstract;
using Business.Constants;
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

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(int id)
        {
            var data = _orderDal.Get(p => p.OrderID == id);
            _orderDal.Delete(data);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> EmployeeID(int id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.EmployeeID == id));
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetById(int id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.OrderID == id));
        }

        public IDataResult<List<Order>> GetAllByShipVia(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.ShipVia >= min && p.ShipVia <= max));
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
