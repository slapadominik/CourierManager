using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuznia.Helpers.Extensions
{
    public static class ListExtensions
    {
        /*/
         
          
        /*/
        public static void PopulateFromXmlFile<T>(this List<T> list, string filePath)
        {
            {
                XMLSerializer<List<T>> serializer = new XMLSerializer<List<T>>(filePath);
                list = serializer.Deserialize();             
            }
        }
    }
}
