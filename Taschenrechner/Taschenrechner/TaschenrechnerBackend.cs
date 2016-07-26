using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class TaschenrechnerBackend
    {
        public void Berechne(char input, Action<string> anzeigen, Action<string> fehler)
        {
            
        }

        public void Zerlegen(char input, Action<char> zifferErkannt, Action<char> operatorErkannt)
        {
            if (char.IsDigit(input))
                zifferErkannt(input);
            else
                operatorErkannt(input);
        }
    }
}
