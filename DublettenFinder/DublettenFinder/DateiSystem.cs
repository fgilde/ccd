using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace DublettenFinder
{
    public static class DateiSystem
    {
        public static IEnumerable<Datei> SammleDatein(string path)
        {
            return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
                .Select(fp => new Datei(new FileInfo(fp)));
        }

        public static byte[] ReadAllBytes(Datei datei)
        {
            return File.ReadAllBytes(datei.Pfad);
        }
    }
}
