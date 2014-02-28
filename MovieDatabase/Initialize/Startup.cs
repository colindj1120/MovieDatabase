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
using MovieDatabase.AddMovies;
using MovieDatabase.Objects;
using MovieDatabase.HelperFunctions;
using MovieDatabase.Database;



namespace MovieDatabase.Initialize
{
    public partial class Startup : Form
    {
        private List<Movies> movieList = new List<Movies>();
        private XmlDocument xml = new XmlDocument();
        private string UserPath { get; set; }
        private string UserDirectory { get; set; }
        private string currentDomain = AppDomain.CurrentDomain.BaseDirectory;

        public Startup()
        {
            InitializeComponent();
            UserDirectory = currentDomain + "Movies\\";
            UserPath = UserDirectory + "Database.xml";
            movieList = LoadXML.loadXML(UserPath, UserDirectory, xml);
        }



        private void viewDatabaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateDatabase database = new CreateDatabase(movieList);
            database.ShowDialog();
            this.Dispose();

        }

        private void addMoviesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMovie add = new AddMovie(xml, UserPath, movieList);
            if (add.ShowDialog() != DialogResult.Cancel)
            {
                movieList = add.getMovieList();
            }
            this.Show();
        }
    }
}
