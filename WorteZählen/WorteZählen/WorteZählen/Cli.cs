using System;
using System.Linq;
using CLAP;

namespace WorteZ�hlen
{
    internal class Cli
    {
        private string textdateiPfad;
        private bool indexGew�nscht;
        private string dictionaryPfad;


        public bool Index_gew�nscht => indexGew�nscht;
        public string Dict_Pfad => dictionaryPfad;

        public bool Pr�fbericht_gew�nscht => !string.IsNullOrEmpty(dictionaryPfad);


        public Cli(string[] args)
        {
            Parser.Run(args, this);
        }

        [Verb(IsDefault = true)]
        public void Run(
            [Aliases("t")] string textdatei_pfad,
            [Aliases("i,index"), DefaultValue(false)] bool index_gew�nscht,
            [Aliases("d,dictionary"), DefaultValue("")] string dictionary_pfad)
        {
            dictionaryPfad = dictionary_pfad;
            indexGew�nscht = index_gew�nscht;
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