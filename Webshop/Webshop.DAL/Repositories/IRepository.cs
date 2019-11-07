using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.DAL.Repositories
{
    interface IRepository<T>
    {
        void Add(T t );
        T FinById(int? id);
        void Modify();
        List<T> GetAll();
        void Remove(T t);
    }
}
