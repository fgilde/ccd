using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    public class CLI
    {
        public static void ReadFilename(string[] args, Action<string> onSuccess, Action<string> onFailure)
        {
            if (args.Any())
                onSuccess(args[0]);
            else
                onFailure("Dateiname fehlt!");
        }
    }
}
