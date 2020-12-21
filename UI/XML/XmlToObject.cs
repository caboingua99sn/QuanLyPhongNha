using System;
using System.IO;
using System.Xml.Serialization;

namespace XML
{
    public class XmlToObject<T>
    {
        public T XML2object(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                T result = (T)ser.Deserialize(reader);
                return result;
            }
        }
    }
}
