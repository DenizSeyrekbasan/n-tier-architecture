using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : IOrderDal
    {
        public void Add(Order entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referansi yakalama
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Order entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referansi yakalama
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Order>().SingleOrDefault(filter);
            }
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Order>().ToList() //filtre null'sa burasi calisicak, tum data gelicek
                    : context.Set<Order>().Where(filter).ToList(); //null degilse filtreyi dondurecek
            }
        }

        public void Update(Order entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referansi yakalama
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
