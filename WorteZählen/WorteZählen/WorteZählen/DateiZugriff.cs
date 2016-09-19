using System.IO;

namespace WorteZählen
{
    internal class DateiZugriff 
    {
        public string[] Stopwörter_laden()
        {
            return File.ReadAllLines("StopWords.txt");
        }
    }
}