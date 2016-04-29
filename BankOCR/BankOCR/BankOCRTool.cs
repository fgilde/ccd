using System;
using System.Collections.Generic;
using System.IO;
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
            // Lese Datei ein => Zeilen
            var rows = File.ReadAllLines(filePath);

            // Zeilen auftrennen in 3er Pakete
            var packets = SplitIntoPackets(rows);

            // Diese Pakete Parsen 
            var result = ParsePackets(packets);

            return result.ToArray();
        }

        public static IEnumerable<string> ParsePackets(string[][] packets)
        {
            return packets.Select(FlattenOCRDigits).Select(MapToRow);
        }

        public static string MapToRow(IEnumerable<string> flatStrings)
        {
            var mappingTable = new[] {
                " _ I II_I" /*0*/,
                "     I  I" /*1*/,
                " _  _II_ " /*2*/,
                " _  _I _I" /*3*/,
                "   I_I  I" /*4*/,
                " _ I_  _I" /*5*/,
                " _ I_ I_I" /*6*/,
                " _   I  I" /*7*/,
                " _ I_II_I" /*8*/,
                " _ I_I _I" /*9*/};
            return string.Join(string.Empty, flatStrings.Select(fs => Array.IndexOf(mappingTable, fs)));
        }

        public static IEnumerable<string> FlattenOCRDigits(string[] digits)
        {
            for (int i = 0; i < digits[0].Length; i += 4)
                yield return digits[0].Substring(i, 3) + digits[1].Substring(i, 3) + digits[2].Substring(i, 3);
        }

        public static string[][] SplitIntoPackets(string[] rows)
        {
            var result = new List<string[]>();

            var packet = new string[3];
            for (int i = 0; i < rows.Length; i++)
            {
                if ((i + 1)%4 != 0)
                {
                    packet[i%4] = rows[i];
                }
                else
                {
                    result.Add(packet);
                    packet =new string[3];
                }
            }
            result.Add(packet);
            return result.ToArray();
        }

    }
}
