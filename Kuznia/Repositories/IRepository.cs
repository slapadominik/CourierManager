using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T t);
        void Delete(int index);
        Client Get(int index);
        void Update(int index, T t);
        List<T> GetAll();
    }
}
