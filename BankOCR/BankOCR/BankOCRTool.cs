using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    public class BankOCRTool
    {
        static void Main(string[] args)
        {
            string[] ausgabe = RecognizeDigitsInFile(args[0]);
        }

        public static string[] RecognizeDigitsInFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
