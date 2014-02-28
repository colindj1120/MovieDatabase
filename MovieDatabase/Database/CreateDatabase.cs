using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieDatabase.Objects;

namespace MovieDatabase.Database
{
    public partial class CreateDatabase : Form
    {
        private List<Movies> movieList;

        public CreateDatabase(List<Movies> movies)
        {
            InitializeComponent();
            movieList = movies;

            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (Movies movie in movieList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(movieDatabase);
                row.Cells[0].Value = movie.MoveName;
                row.Cells[1].Value = movie.TimeLength;
                row.Cells[2].Value = movie.ReleaseDate;
                row.Cells[3].Value = movie.Gross;
                string genre = "";
                foreach (String g in movie.Genres)
                {
                    genre += (g + "/");
                }
                row.Cells[4].Value = genre;
                rows.Add(row);
            }

            movieDatabase.Rows.InsertRange(0, rows.ToArray());
        }

        private void movieDatabase_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            int width = 0;
            width = movieDatabase.Columns[0].Width + movieDatabase.Columns[1].Width + movieDatabase.Columns[2].Width + movieDatabase.Columns[3].Width;
            movieDatabase.Width = width + 90;
            //CreateDatabase.ActiveForm.Width = movieDatabase.Width + 20;
        }
    }
}
