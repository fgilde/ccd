using System;
using System.Collections.Generic;
using System.Linq;
using Questionnaire.Adapter;
using Questionnaire.Daten;

namespace Questionnaire
{
    public class Fragebogen
    {
        public Frage[] Lese_Fragebogen()
        {
            DateiSystem dateiSystem = new DateiSystem();
            List<Frage> fragebogen = new List<Frage>();

            var alle_Zeilen = dateiSystem.Lese_Datei_Zeilenweise();
            Blöcke_Bilden(alle_Zeilen, 
                block_zeilen => fragebogen.Add(Frage_bilden(block_zeilen))
            );

            return fragebogen.ToArray();
        }

        private Frage Frage_bilden(string[] block_zeilen)
        {
            return new Frage
            {
                Text = block_zeilen[0].TrimStart('?'),
                Antworten = block_zeilen.Skip(1).Select(z => new Antwort
                {
                    Text = z.TrimStart('*'),
                    Richtig = z.StartsWith("*")
                }).ToArray()
            };
        }

        private void Blöcke_Bilden(string[] alleZeilen, Action<string[]> block_gefunden)
        {
            List<string> block = null;

            foreach (string zeile in alleZeilen)
            {
                if (zeile.StartsWith("?"))
                {
                    if(block != null)
                        block_gefunden(block.ToArray());
                    block = new List<string>();
                }
                block.Add(zeile);
            }

            if (block != null)
                block_gefunden(block.ToArray());
        }
    }
}