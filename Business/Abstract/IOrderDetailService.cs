using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        List<OrderDetail> GetByOrderId(int id);
        List<OrderDetail> GetByQuantity(int count);
        List<OrderDetail> GetByUnitPrice(int price);
    }
}
