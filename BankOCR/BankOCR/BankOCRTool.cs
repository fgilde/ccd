using System;
using System.IO;
using System.Linq;

namespace BankOCR
{
    public class BankOCRTool
    {
        static void Main(string[] args)
        {
            CLI.ReadFilename(args, 
                filename => {
                    var lines = FileReader.ReadAllLines(filename);
                    var digits = OCR.RecognizeDigits(lines);
                    ConsoleOutput.Write(digits);
                }, 
                ConsoleOutput.WriteError);
        }
    }
}
