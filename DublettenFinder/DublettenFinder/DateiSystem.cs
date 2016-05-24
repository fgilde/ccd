using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DublettenFinder
{
    public static class DateiSystem
    {
        public static IEnumerable<Datei> SammleDatein(string path)
        {
            return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
                .Select(fp => new Datei(new FileInfo(fp)));
        } 
    }
}
