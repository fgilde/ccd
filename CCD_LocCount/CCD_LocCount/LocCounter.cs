using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CCD_LocCount
{
    public static class LocCounter
    {
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