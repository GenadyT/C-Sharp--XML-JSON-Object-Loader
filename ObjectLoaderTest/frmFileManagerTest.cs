using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Developments.MusicGenres;
using FileManager;

namespace Developments
{
    public partial class frmFileManagerTest : Form
    {
        public frmFileManagerTest()
        {
            InitializeComponent();
            SubInit();
        }

        private void SubInit()
        {

        }

        private void btnReadTextRows_Click(object sender, EventArgs e)
        {
            string path = DataFilePath("MusicGenres.txt");
            string[] musicGenres = ObjectLoader.ReadFileRows(path);

            for (int i = 0; i < musicGenres.Length; i++)
            {
                tbxTextFileRows.AppendText(musicGenres[i]);
                tbxTextFileRows.AppendText(Environment.NewLine);
            }
        }

        private void btnReadXmlObject_Click(object sender, EventArgs e)
        {
            string path = DataFilePath("MusicGenres.xml");
            MusicGenreList genreList = ObjectLoader.ReadXmlObjects<MusicGenreList>(path);

            foreach (var genre in genreList.MusicGenres)
            {
                tbxObjectFromXml.AppendText(genre.ToString());
                tbxObjectFromXml.AppendText(Environment.NewLine);
            }
        }

        private void btnReadJsonObject_Click(object sender, EventArgs e)
        {
            string path = DataFilePath("MusicGenres.json");
            MusicGenreList genreList = ObjectLoader.ReadJsonObjects<MusicGenreList>(path);

            foreach (var genre in genreList.MusicGenres)
            {
                tbxObjectFromJson.AppendText(genre.ToString());
                tbxObjectFromJson.AppendText(Environment.NewLine);
            }
        }

        private string DataFilePath(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\" + fileName);
        }
    }
}
