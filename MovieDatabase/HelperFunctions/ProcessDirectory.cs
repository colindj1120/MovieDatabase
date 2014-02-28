using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieDatabase.HelperFunctions
{
    static class ProcessDirectory
    {
        public static void processDirectory(string dir, List<string> movies)
        {
            string[] fileEntries = Directory.GetFiles(dir);
            foreach (string fileName in fileEntries)
            {
                if (!fileName.Contains(".srt") && !fileName.Contains(".db"))
                {
                    string[] split = fileName.Split('\\');
                    int index = split[split.Length - 1].LastIndexOf('.');
                    string sub = split[split.Length - 1].Substring(0, index);
                    movies.Add(sub);
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                processDirectory(subdirectory, movies);
            }
        }
    }
}
