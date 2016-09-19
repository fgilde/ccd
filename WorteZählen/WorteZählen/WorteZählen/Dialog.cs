using System;

namespace WorteZählen
{
    internal class Dialog
    {
        public string Fordere_Eingabe()
        {
            Console.Write("Enter text: ");
            return Console.ReadLine();
        }

        public void Zeige_Anzahl_Wörter(Ergebnis ergebnis)
        {
            Console.WriteLine($"Number of words: {ergebnis.Anzahl_Wörter}, unique: {ergebnis.Anzahl_eindeutiger_Wörter}");
        }
    }
}