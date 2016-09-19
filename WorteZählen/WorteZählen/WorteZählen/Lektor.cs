using System.Collections.Generic;
using System.Linq;

namespace WorteZählen
{
    public class Lektor
    {
        public static string[] Ermittle_unbekannte_Worte(string[] worte, HashSet<string> dict)
        {
            if (dict.Count == 0)
                return new string[0];
            
            return worte.Where(ew => !dict.Contains(ew)).ToArray();
        }
    }
}
