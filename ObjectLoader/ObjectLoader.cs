using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FileManager
{
    public static class ObjectLoader
    {
        /*public static string ReadFileString(string path)
        {
            if (!File.Exists(path)) return null;

            return File.ReadAllText(path, Encoding.UTF8);
        }*/

        public static string[] ReadFileRows(string path)
        {
            if (!File.Exists(path)) return null;

            return File.ReadAllLines(path, Encoding.UTF8);
        }

        public static T ReadXmlObjects<T>(string path) where T : class
        {
            if (!File.Exists(path)) return null;

            T result;

            using (StreamReader reader = File.OpenText(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(reader);
            }

            return result;
        }        

        public static T ReadJsonObjects<T>(string path) where T : class
        {
            if (!File.Exists(path)) return null;

            T result;

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                result = JsonSerializer.Deserialize<T>(json);
            }

            return result;
        }
    }
}
