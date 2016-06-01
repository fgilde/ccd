using System.IO;
using System.Security.Cryptography;
using System.Text;

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

        public byte[] MD5Hash =>  MD5.Create("MD5").ComputeHash(DateiSystem.ReadAllBytes(this));
        
    }
}
