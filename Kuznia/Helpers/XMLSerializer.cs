using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kuznia.Helpers
{
    public class XMLSerializer<T> : ISerializer<T> where T : class
    {
        private XmlSerializer _serializer;
        private readonly string FileName;

        public XMLSerializer(string fileName = "SerializedXML")
        {
            _serializer = new XmlSerializer(typeof(T));
            FileName = Constants.BASE_FILE_PATH + fileName;
        }

        public void Serialize(T t)
        {
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            {
                _serializer.Serialize(streamWriter, t);
                streamWriter.Flush();
            }
        }

        public T Deserialize()
        {
            if (!File.Exists(FileName))
            {
                return null;
            }
            T t = null;
            using (StreamReader streamReader = new StreamReader(FileName))
            {
                t = (T) _serializer.Deserialize(streamReader);
            }
            return t;
        }
    }
}
