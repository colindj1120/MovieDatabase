using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using MovieDatabase.Objects;

namespace MovieDatabase.HelperFunctions
{
    class LoadXML
    {
        private static List<Movies> movieList = new List<Movies>();

        public static List<Movies> loadXML(string path, string directory, XmlDocument xml)
        {
            if (File.Exists(path))
            {
                xml.Load(path);
                foreach (XmlNode xn in xml.ChildNodes[1])
                {
                    Movies movie = new Movies();
                    foreach (XmlNode xcn in xn)
                    {
                        if (xcn.Name.Equals("Name"))
                        {
                            movie.MoveName = xcn.InnerText;
                        }
                        else if (xcn.Name.Equals("Genre"))
                        {
                            movie.Genres.Add(xcn.InnerText);
                        }
                        else if (xcn.Name.Equals("Runtime"))
                        {
                            movie.TimeLength = xcn.InnerText;
                        }
                        else if (xcn.Name.Equals("Gross"))
                        {
                            movie.Gross = xcn.InnerText;
                        }
                        else if (xcn.Name.Equals("ReleaseDate"))
                        {
                            movie.ReleaseDate = xcn.InnerText;
                        }
                        else
                        {
                            //throw exception
                        }
                    }
                    movieList.Add(movie);
                }
            }
            else
            {
                xml.LoadXml("<Movies></Movies>");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                XmlTextWriter writer = new XmlTextWriter(path, null);
                writer.Formatting = Formatting.Indented;
                xml.Save(writer);
            }
            return movieList;
        }
    }
}
