using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CCD_LocCount
{
    public static class LocCounter
    {
        public static void LocCountLinq(string path, Action<string> foundFileAction)
        {
            var found = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
                .Select(fp => new FileInfo(fp))
                .Where(fi => fi.Extension == ".cs")
                .Select(fi => $"{fi.Name};{LOC(File.ReadAllText(fi.FullName))};{File.ReadAllLines(fi.FullName).Length}");

            foreach (var f in found)
                foundFileAction(f);
        }

        public static void LocCount(string path, Action<string> foundFileAction)
        {
            
        }

        public static int LOC(string sourceCode)
        {
            var sourceWithOutComments = DeleteComments(sourceCode);
            var lines = DecomposeInLines(sourceWithOutComments);
            lines = DeleteEmptyLines(lines);
            return lines.Length;
        }

        public static string[] DeleteEmptyLines(string[] lines)
        {
            return lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();
        }

        public static string[] DecomposeInLines(string sourceOnly)
        {
            return sourceOnly.Split('\n');
        }

        public static string DeleteComments(string sourceCode)
        {
            var pattern = @"(@(?:""[^""]*"")+|""(?:[^""\r\n\\]+|\\.)*""|'(?:[^'\r\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
            return Regex.Replace(sourceCode, pattern, Environment.NewLine);
        }
    }
}