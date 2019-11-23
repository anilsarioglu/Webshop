using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BL
{
    public interface ILogic<T> where T : class
    {
        void Create(T t);
        T FindByID(int? id);
        void Delete(T t);
        List<T> GetAll();
        void Update(T t);
    }
}
