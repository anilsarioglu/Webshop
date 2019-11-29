using System.Collections.Generic;

namespace Webshop.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        void Add(TEntity t );
        TEntity FindById(int? id);
        void Modify(TEntity t);
        List<TEntity> GetAll();
        void Remove(TEntity t);
    }
}
