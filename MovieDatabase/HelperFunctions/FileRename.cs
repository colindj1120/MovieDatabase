using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.HelperFunctions
{
    class FileRename
    {
        private Dictionary<string, string> fileDictionary = new Dictionary<string, string>();

        public FileRename()
        {
            fileDictionary.Add("50-50", "50/50");
            fileDictionary.Add("Aladdin 2 - The Return of Jafar", "The Return of Jafar");
            fileDictionary.Add("Aladdin 3 - The King of Thieves", "Aladdin and the King of Thieves");
            fileDictionary.Add("Anger Management", "Anger Management (2003)");
            fileDictionary.Add("Alien Resurrection", "Alien Resurrection (1997)");
            fileDictionary.Add("Abraham Lincoln Vampire Hunter", "Abraham Lincoln Cazador de vampiros");
            fileDictionary.Add("A Nightmare On Elm Street 6 - Freddy's Dead - The Final Nightmare", "Freddy's Dead: The Final Nightmare");
            fileDictionary.Add("The Animal", "The Animal (2001)");
            fileDictionary.Add("Alien 1", "Alien");
            fileDictionary.Add("Alien 2", "Aliens");
            fileDictionary.Add("American Pie 1", "American Pie");
            fileDictionary.Add("Bad Boys 1", "Bad Boys");
            fileDictionary.Add("Beauty and the Beast", "Beauty and the Beast (1991)");
            fileDictionary.Add("Behind Enemy Lines 1", "Behind Enemy Lines");
            fileDictionary.Add("Big Momma's House 1", "Big Momma's House");
            fileDictionary.Add("The Black Hole", "The Black Hole (2006)");
            fileDictionary.Add("Blade Trinity", "Blade Trinity (2004)");
            fileDictionary.Add("Bloodrayne 3 - The Third Reich", "Bloodrayne: The Third Reich");
            fileDictionary.Add("The Butterfly Effect 1", "The Butterfly Effect");
            fileDictionary.Add("Blade 1", "Blade");
            fileDictionary.Add("Bloodrayne 1", "Bloodrayne");
            fileDictionary.Add("Bloodsport 1", "Bloodsport");
            fileDictionary.Add("Cars 1", "Cars");
            fileDictionary.Add("Child's Play 1", "Child's Play");
            fileDictionary.Add("Code Name The Cleaner", "Code Name The Cleaner (2007)");

        }
        public string rename(string file)
        {
            if (fileDictionary.ContainsKey(file))
            {
                file = fileDictionary[file];
                return file;
            }
            else
            {
                return "";
            }
        }
    }
}
