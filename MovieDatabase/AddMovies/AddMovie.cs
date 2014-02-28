using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Timers;
using System.Threading;
using MovieDatabase.Objects;
using MovieDatabase.HelperFunctions;

namespace MovieDatabase.AddMovies
{
    public partial class AddMovie : Form
    {
        private XmlDocument xml;
        public string UserPath { get; set; }
        private List<Movies> movieList;
        private string folderPath = "";
        private string fileName = "";
        private bool paused = true;
        private ProcessingForm process;

        public AddMovie(XmlDocument xml, string userPath, List<Movies> movies)
        {
            InitializeComponent();
            this.xml = xml;
            UserPath = userPath;
            movieList = movies;
        }

        private void folderPathBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath = fbd.SelectedPath;
                folderTextBox.Text = folderPath;
            }
        }

        private void filePathBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All|*.*";
            ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                fileTextBox.Text = fileName;
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(() =>
                {
                    process = new ProcessingForm();
                    process.ShowDialog();
                }));
            Thread t2 = new Thread(new ThreadStart(() =>
                {
                    if (fileName.Length == 0 && folderPath.Length == 0)
                    {
                        MessageBox.Show("Please make sure you select a file OR a folder path");
                        return;
                    }
                    else if (fileName.Length > 0 && folderPath.Length == 0)
                    {
                        string[] split = fileName.Split('\\');
                        int index = split[split.Length - 1].LastIndexOf('.');
                        string sub = split[split.Length - 1].Substring(0, index);
                        CreateMovie.createMovie(sub, movieList);
                    }
                    else if (fileName.Length == 0 && folderPath.Length > 0)
                    {
                        List<string> movies = new List<string>();
                        ProcessDirectory.processDirectory(folderPath, movies);
                        foreach (string file in movies)
                        {
                            CreateMovie.createMovie(file, movieList);
                        }
                    }
                    else
                    {
                        CreateMovie.createMovie(fileName, movieList);
                    }
                    paused = false;
                }));

            t1.Start();
            t2.Start();

            while (paused == true) { }
            Invoke(new Action(() =>
                {
                    process.timer.Stop();
                    process.timer.Enabled = false;
                    process.Dispose();
                }));
            t1.Abort();
            t2.Abort();

            /**
             * 
             * save movie list to xml
             * 
             **/

            Dispose();
        }

        private void cancelMovieButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public List<Movies> getMovieList()
        {
            return movieList;
        }

        private void folderTextBox_TextChanged(object sender, EventArgs e)
        {
            folderPath = folderTextBox.Text;
        }

        private void fileTextBox_TextChanged(object sender, EventArgs e)
        {
            fileName = fileTextBox.Text;
        }
    }
}
