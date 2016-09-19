using System;
using System.Linq;

namespace WorteZählen
{
    internal class Dialog
    {
        public string Fordere_Eingabe()
        {
            Console.Write("Enter text: ");
            return Console.ReadLine();
        }

        public void Zeige_Ergebnis(Ergebnis ergebnis, bool index_gewünscht)
        {
            Console.WriteLine($"Number of words: {ergebnis.Anzahl_Wörter}, " +
                              $"unique: {ergebnis.Anzahl_eindeutiger_Wörter}; " +
                              $"average word length: {ergebnis.Durchschnittliche_Wortlänge:N1} characters");

            
            if (index_gewünscht)
            {
                Console.WriteLine("Index:");
                Console.WriteLine(string.Join(Environment.NewLine, ergebnis.Eindeutige_Wörter.OrderBy(w => w)));
            }
        }
    }
}