using Business.Abstract;
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

        public List<OrderDetail> GetAll()
        {
            return _orderDetail.GetAll();
        }

        public List<OrderDetail> GetByQuantity(int count)
        {
            return _orderDetail.GetAll(p => p.Quantity == count);
        }

        public List<OrderDetail> GetByOrderId(int id)
        {
            return _orderDetail.GetAll(p => p.OrderID == id);
        }

        public List<OrderDetail> GetByUnitPrice(int price)
        {
            return _orderDetail.GetAll(p => p.UnitPrice == price);
        }
    }
}
