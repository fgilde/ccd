using System.IO;

namespace WorteZählen
{
    internal class DateiZugriff 
    {
        public static string[] Stopwörter_laden()
        {
            return File.ReadAllLines("StopWords.txt");
        }
    }
}