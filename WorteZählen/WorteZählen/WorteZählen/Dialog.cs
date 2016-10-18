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

        public void Zeige_Ergebnis(Ergebnis ergebnis, string[] unbekannte_Worte, bool index_gewünscht, bool prüfbericht_gewünscht)
        {
            Console.WriteLine($"Number of words: {ergebnis.Anzahl_Wörter}, " +
                              $"unique: {ergebnis.Anzahl_eindeutiger_Wörter}; " +
                              $"average word length: {ergebnis.Durchschnittliche_Wortlänge:N1} characters");

            
            if (index_gewünscht)
            {
                if (prüfbericht_gewünscht)
                    Console.WriteLine($"Index (unbekannt: {unbekannte_Worte.Length}):");
                else
                    Console.WriteLine("Index:");

                var index = ergebnis.Eindeutige_Wörter.OrderBy(w => w);

                foreach (var wort in index)
                {
                    Console.Write(wort);
                    if (prüfbericht_gewünscht && unbekannte_Worte.Contains(wort))
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}