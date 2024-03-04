using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Developments.MusicGenres
{
    public class MusicGenre
    {
        [XmlElement("ID")]
        public int ID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }        

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
