using System.Collections.Generic;

namespace Webshop.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class //It's a type constraint on T, specifying that it must be a class.
    {
        void Create(TEntity t );
        TEntity Read(int? id);
        void Update();
        List<TEntity> GetAll();
        void Delete(TEntity t);
    }
}
