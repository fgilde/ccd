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

        public string MD5Hash =>  Encoding.Default.GetString(MD5.Create().ComputeHash(DateiSystem.ReadAllBytes(this)));
        
    }
}
