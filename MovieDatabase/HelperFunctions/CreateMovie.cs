using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDatabase.Objects;
using TMDbLib.Client;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Utilities;

namespace MovieDatabase.HelperFunctions
{
    static class CreateMovie
    {
        public static void createMovie(string file, List<Movies> movieList)
        {
            List<string> failList = new List<string>();
            List<string> rev0List = new List<string>();

            FileRename renamer = new FileRename();
            string renamed = renamer.rename(file);
            if (!renamed.Equals(""))
            {
                file = renamed;
            }

            try
            {
                TMDbClient client = new TMDbClient("65f38f566f156663a730d04bf09f3dc6");
                var imdb = new Imdb();
                if (imdb.Search(file))
                {
                    string imdbID = "tt" + imdb.Id;
                    Movie movie = client.GetMovie(imdbID);
                    Movies currentMovie = new Movies();
                    currentMovie.MoveName = movie.Title;
                    currentMovie.TimeLength = movie.Runtime.ToString();
                    currentMovie.Gross = movie.Revenue.ToString();
                    currentMovie.ReleaseDate = movie.ReleaseDate.Value.Month + "/" + movie.ReleaseDate.Value.Day + "/" + movie.ReleaseDate.Value.Year;
                    foreach (Genre genre in movie.Genres)
                    {
                        currentMovie.Genres.Add(genre.Name);
                    }
                    movieList.Add(currentMovie);
                    if(currentMovie.Gross.Equals("0"))
                    {
                        throw new ApplicationException();
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Fail:    " + file);
            }
            catch (ApplicationException)
            {
                Console.WriteLine("0 Gross:       " + file);
            }

        }
    }
}
