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
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implementation of C#
            //C#'a ozgu bir yapi
            //using icerisinde kullandigimiz yapi isimiz bittigi anda garbage collector cagirilip onu bellekten aticaktir
            //performansli bir yapi kurmamizi sagliyor
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referansi yakalama
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }       
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //referansi yakalama
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() //filtre null'sa burasi calisicak, tum data gelicek
                    : context.Set<Product>().Where(filter).ToList(); //null degilse filtreyi dondurecek
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); //referansi yakalama
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
