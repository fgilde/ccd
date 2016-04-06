using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CCD_LocCount
{
    public static class LocCounter
    {
        public static int LOC(string sourceCode)
        {
            var sourceOnly = DeleteAllComments(sourceCode);
            var lines = ZerlegeInZeilen(sourceOnly);
            var trimmedLines = LöscheAlleLeerzeilen(lines);

            return trimmedLines.Length;
        }

        public static string[] LöscheAlleLeerzeilen(string[] lines)
        {
            return lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();
        }

        public static string[] ZerlegeInZeilen(string sourceOnly)
        {
            return sourceOnly.Split('\n');
        }

        public static string DeleteAllComments(string sourceCode)
        {
            var pattern = @"(@(?:""[^""]*"")+|""(?:[^""\r\n\\]+|\\.)*""|'(?:[^'\r\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
            return Regex.Replace(sourceCode, pattern, Environment.NewLine);
        }
    }
}