using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuznia.Helpers
{
    public interface ISerializer<T> where T : class
    {
        void Serialize(T t);
        T Deserialize();
    }
}
