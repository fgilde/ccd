using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DublettenFinder
{
    public class Dublette : IDublette
    {
        public IEnumerable<string> Dateipfade { get; set; }
    }
}
