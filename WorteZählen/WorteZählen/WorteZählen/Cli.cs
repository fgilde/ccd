using System;
using System.Linq;
using CLAP;

namespace WorteZählen
{
    internal class Cli
    {
        private string textdateiPfad;
        private bool indexGewünscht;
        private string dictionaryPfad;


        public bool Index_gewünscht => indexGewünscht;
        public string Dict_Pfad => dictionaryPfad;

        public bool Prüfbericht_gewünscht => !string.IsNullOrEmpty(dictionaryPfad);


        public Cli(string[] args)
        {
            Parser.Run(args, this);
        }

        [Verb(IsDefault = true)]
        public void Run(
            [Aliases("t")] string textdatei_pfad,
            [Aliases("i,index"), DefaultValue(false)] bool index_gewünscht,
            [Aliases("d,dictionary"), DefaultValue("")] string dictionary_pfad)
        {
            dictionaryPfad = dictionary_pfad;
            indexGewünscht = index_gewünscht;
            textdateiPfad = textdatei_pfad;
        }

        public void Pfad_lesen(Action<string> pfad_gefunden, Action kein_Pfad_gefunden)
        {
            if (textdateiPfad != null)
                pfad_gefunden(textdateiPfad);
            else
                kein_Pfad_gefunden();
        }

        
    }
}