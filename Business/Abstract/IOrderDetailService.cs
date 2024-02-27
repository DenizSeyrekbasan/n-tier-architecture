using Core.Utilities.Results;
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
        IDataResult<List<OrderDetail>> GetAll();
        IDataResult<List<OrderDetail>> GetByOrderId(int id);
        IDataResult<List<OrderDetail>> GetByQuantity(int count);
        IDataResult<List<OrderDetail>> GetByUnitPrice(int price);
    }
}
