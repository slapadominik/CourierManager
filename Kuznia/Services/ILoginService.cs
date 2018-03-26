using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuznia.Services
{
    interface ILoginService<T> where T : class
    {
        void Login(T t);

    }
}
