using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    public class ConsoleOutput
    {
        public static void Write(IEnumerable<string> lines)
        {
            foreach (var line in lines)
                Console.WriteLine(line);
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }
}
