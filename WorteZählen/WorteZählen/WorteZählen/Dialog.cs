using System;

namespace WorteZählen
{
    internal class Dialog
    {
        public static string Fordere_Eingabe()
        {
            Console.Write("Enter text: ");
            return Console.ReadLine();
        }

        public static void Zeige_Anzahl_Wörter(int i)
        {
            Console.WriteLine($"Number of words: {i}");
        }
    }
}