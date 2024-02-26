using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            //C#'a ozgu bir yapi
            //using icerisinde kullandigimiz yapi isimiz bittigi anda garbage collector cagirilip onu bellekten aticaktir
            //performansli bir yapi kurmamizi sagliyor
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //referansi yakalama
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //referansi yakalama
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() //filtre null'sa burasi calisicak, tum data gelicek
                    : context.Set<TEntity>().Where(filter).ToList(); //null degilse filtreyi dondurecek
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //referansi yakalama
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
