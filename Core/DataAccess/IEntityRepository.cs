using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        //Expression, delege, filtreleme yapicagimiz zaman
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); //eger filtre yoksa tum datayi istiyor
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
