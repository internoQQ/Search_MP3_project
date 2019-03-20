using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MusicSearchByGenre
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                catalogForFindTextBox.Text = fbd.SelectedPath;
            }
        }

        private void findStartButton_Click(object sender, EventArgs e)
        {
            resultListView.Items.Clear();
            string catFind = catalogForFindTextBox.Text.Trim();
            List<string> result = new List<string>(Directory.EnumerateFiles(catFind, "*.mp3", SearchOption.AllDirectories));
            listResult = new List<string>();
            for (int i = 0; i < result.Count; i++)
            {
                bool year = false,
                     album = false,
                     artist = false,
                     genre = false,
                     albumArtist = false,
                     duration = false;

                TagLib.File file = TagLib.File.Create(result[i]);

                if (yearTextBox.Text != "")
                {
                    if (file.Tag.Year.ToString() == yearTextBox.Text)
                        year = true;
                }
                else
                {
                    year = true;
                }
                if (albumTextBox.Text != "")
                {
                    if (file.Tag.Album != null)
                        if (file.Tag.Album.ToLower() == albumTextBox.Text.ToLower())
                            album = true;
                }
                else
                {
                    album = true;
                }
                if (artistsTextBox.Text != "")
                {
                    string[] mass = file.Tag.Artists.ToArray();
                    for (int j = 0; j < mass.Length; j++)
                        if (mass[j].ToLower() == artistsTextBox.Text.ToLower())
                            artist = true;
                }
                else
                {
                    artist = true;
                }                
                if (genresTextBox.Text != "")
                {
                    string[] mass = file.Tag.Genres.ToArray();
                    for (int j = 0; j < mass.Length; j++)
                        if (mass[j].ToLower() == genresTextBox.Text.ToLower())
                            genre = true;
                }
                else
                {
                    genre = true;
                }
                if (albumArtistTextBox.Text != "")
                {
                    string[] mass = file.Tag.AlbumArtists.ToArray();
                    for (int j = 0; j < mass.Length; j++)
                        if (mass[j].ToLower() == albumArtistTextBox.Text.ToLower())
                            albumArtist = true;
                }
                else
                {
                    albumArtist = true;
                }
                //file.Properties.Duration.ToString()
                DateTime time = Convert.ToDateTime(durationMaskedTextBox.Text);
                DateTime time1 = Convert.ToDateTime(file.Properties.Duration.ToString());
                if (radioButton1.Checked)
                {
                    if (time < time1)
                        duration = true;
                }
                else
                {
                    if (time1 < time)
                        duration = true;
                }
                if (year && album && artist && genre && albumArtist && duration)
                {
                    //resultListBox.Items.Add(result[i].Split('\\')[result[i].Split('\\').Length - 1]);
                    listResult.Add(result[i]);

                    ListViewItem item = new ListViewItem(result[i]);
                    item.Tag = file;
                    resultListView.Items.Add(item);
                }
            }
        }
        List<string> listResult = new List<string>();

        private void resultListBox_DoubleClick(object sender, EventArgs e)
        {
            if (resultListView.SelectedIndices[0] != -1)
                Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + listResult[resultListView.SelectedIndices[0]]));
            else
                MessageBox.Show("Выберите файл");
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (resultListView.SelectedIndices[0] != -1)
            {
                listBox1.Items.Clear();
                TagLib.File file = TagLib.File.Create(listResult[resultListBox.SelectedIndex]);

                listBox1.Items.Add(file.Tag.Year.ToString());
                if(file.Tag.Album != null)
                    listBox1.Items.Add(file.Tag.Album.ToString());
                string temp = "";
                foreach (string str in file.Tag.Artists)
                    temp += str + "; ";
                listBox1.Items.Add(temp);
                temp = "";
                foreach (string str in file.Tag.Genres)
                    temp += str + "; ";
                listBox1.Items.Add(temp);
                temp = "";
                foreach (string str in file.Tag.AlbumArtists)
                    temp += str + "; ";
                listBox1.Items.Add(temp);
                listBox1.Items.Add(file.Properties.Duration.ToString());
            }*/
        }
    }
}
