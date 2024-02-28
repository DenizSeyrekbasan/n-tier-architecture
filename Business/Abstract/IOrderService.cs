using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetById(int id);
        IDataResult<List<Order>> GetAllByShipVia(decimal min, decimal max);
        IResult Add(Order order);
        IResult Delete(int id);
        IResult Update(Order order);
    }
}
