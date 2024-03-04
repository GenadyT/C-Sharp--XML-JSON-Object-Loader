using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Developments.MusicGenres
{
    [XmlRoot("MusicGenres")]
    public class MusicGenreList
    {
        [XmlElement("Genre")]
        public List<MusicGenre> MusicGenres { get; set; }
    }
}
