using System;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;

namespace MovieDatabase.HelperFunctions
{
    class Imdb
    {
        private HtmlAgilityPack.HtmlDocument _markup;

        public bool Search(string query)
        {
            HtmlWeb web = new HtmlWeb();
            _markup = web.Load("http://www.imdb.com/find?q=" + HttpUtility.UrlEncode(query) + "&s=all");

            if (!IsMoviePage())
            {
                string urlBestResult = FindBestMatch();
                if (!String.IsNullOrEmpty(urlBestResult))
                {
                    _markup = web.Load(urlBestResult);
                }
                else return false;
            }
            bool isMovie = IsMoviePage();

            return isMovie;
        }


        private bool IsMoviePage()
        {
            return (_markup.DocumentNode.SelectSingleNode("//div[@id='titleCast']") != null);
        }


        private string FindBestMatch()
        {
            HtmlNodeCollection headers = _markup.DocumentNode.SelectNodes("//h3[@class='findSectionHeader']");
            if (headers != null) foreach (HtmlNode header in headers)
            {
                HtmlNode link = header.ParentNode.SelectSingleNode(".//a[contains(@href, '/title/')]");
                if (link != null)
                {
                    return "http://www.imdb.com" + link.Attributes["href"].Value;
                }
            }
            return String.Empty;
        }

        public string Link
        {
            get
            {
                HtmlNode link = _markup.DocumentNode.SelectSingleNode("//link[contains(@rel, 'canonical')]");
                return link == null ? String.Empty : link.Attributes["href"].Value;
            }
        }


        public string Id
        {
            get
            {
                return this.Link.Replace("http://www.imdb.com/title/tt", String.Empty).TrimEnd('/');
            }
        }
    }
}
