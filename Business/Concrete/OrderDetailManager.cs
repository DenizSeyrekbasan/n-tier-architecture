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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetail;

        public OrderDetailManager(IOrderDetailDal orderDetail)
        {
            _orderDetail = orderDetail;
        }

        public IDataResult<List<OrderDetail>> GetAll()
        {
            return new SuccessDataResult<List<OrderDetail>> (_orderDetail.GetAll());
        }

        public IDataResult<List<OrderDetail>> GetByQuantity(int count)
        {
            return new SuccessDataResult<List<OrderDetail>> (_orderDetail.GetAll(p => p.Quantity == count));
        }

        public IDataResult<List<OrderDetail>> GetByOrderId(int id)
        {
            return new SuccessDataResult<List<OrderDetail>> (_orderDetail.GetAll(p => p.OrderID == id));
        }

        public IDataResult<List<OrderDetail>> GetByUnitPrice(int price)
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetail.GetAll(p => p.UnitPrice == price));
        }
    }
}
