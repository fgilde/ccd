using System.IO;

namespace BankOCR
{
    public class FileReader
    {
        public static string[] ReadAllLines(string filename)
        {
            return File.ReadAllLines(filename);
        }
    }
}
