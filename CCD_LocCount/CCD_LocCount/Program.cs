using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCD_LocCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocCount(args[0], Console.WriteLine);
        }

        public static void LocCount(string path, Action<string> processLineAction)
        {
            var csFilePaths = GetCsFilePaths(path);
            foreach (var csFilePath in csFilePaths)
            {
                var content = ReadFileContent(csFilePath);
                var lof = CountLof(content);
                var loc = LocCounter.LOC(content);
                var outputLine = FormatLine(csFilePath, loc, lof);
                processLineAction(outputLine);
            }
        }

        public static string FormatLine(string csFilePath, int loc, int lof)
        {
            return string.Format("{0};{1};{2}", csFilePath, loc, lof);
        }

        public static int CountLof(string content)
        {
            return content.Split('\n').Length;
        }

        public static string ReadFileContent(string fullFilePath)
        {
            return File.ReadAllText(fullFilePath);
        }

        public static string[] GetCsFilePaths(string path)
        {
            return Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories);
        }
    }
}
    