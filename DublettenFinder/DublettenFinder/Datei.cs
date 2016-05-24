using System.IO;

namespace DublettenFinder
{
    public class Datei 
    {
        public Datei(FileInfo fi)
        {
            Name = fi.Name;
            Size = fi.Length;
            Pfad = fi.FullName;
        }

        public string Name { get; set; }
        public string Pfad { get; set; } 
        public long Size { get; set; } 
    }
}
