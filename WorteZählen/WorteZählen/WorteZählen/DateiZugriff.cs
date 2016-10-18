using System.Collections.Generic;
using System.IO;

namespace WorteZählen
{
    internal class DateiZugriff 
    {
        public string[] Stopwörter_laden()
        {
            return File.ReadAllLines("StopWords.txt");
        }

        public string Textdatei_lesen(string pfad)
        {
            return File.ReadAllText(pfad);
        }

        public HashSet<string> LeseDictionary(string pfad)
        {
            if (string.IsNullOrEmpty(pfad))
                return new HashSet<string>();
            return new HashSet<string>(File.ReadAllLines(pfad));
        } 
    }
}