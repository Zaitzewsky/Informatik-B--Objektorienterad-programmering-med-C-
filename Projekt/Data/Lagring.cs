using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    public class Serializer<T> where T : class
    {
        private XmlSerializer xml;
        public Serializer()
        {
            xml = new XmlSerializer(typeof(T));
        }
        public void Serialize(StreamWriter s, T obj)
        {
            xml.Serialize(s, obj);
        }
        public T Deserialize(StreamReader s)
        {
            return xml.Deserialize(s) as T;
        }
    }
}
