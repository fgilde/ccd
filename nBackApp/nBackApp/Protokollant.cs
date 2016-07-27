using System;
using System.IO;
using System.Text;

namespace nBackApp
{
    public class Protokollant
    {
        public void Schreiben(SpielStand spielStand, Reizspeicher reizspeicher)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Proband {spielStand.Profil.Name}");
            sb.AppendLine($"Reizdauer {spielStand.Profil.Dauer}");
            sb.AppendLine($"N = {spielStand.Profil.N} Start = {DateTime.Now.ToLongDateString()}");
            sb.AppendLine($"Reize = {string.Join("", reizspeicher.Reize)}");
            sb.AppendLine($"Antworten = {string.Join("", spielStand.AlleAntworten())}");

            File.WriteAllText($"{DateTime.Now.ToShortDateString()}-{spielStand.Profil.Name}.txt", sb.ToString());
            //File.WriteAllText(@"C:\temp\x.txt", "x");

        }
    }
}