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
            string[] result = ParsePackets(packets);

            return result;
        }

        public static string[] ParsePackets(string[][] packets)
        {
            var mappingTable = new[,] {{" _ ", "I I", "I_I"}, {"   ", "  I", "  I"}};
            
            throw new NotImplementedException();
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
