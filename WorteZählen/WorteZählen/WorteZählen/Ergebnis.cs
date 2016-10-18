namespace WorteZählen
{
    public class Ergebnis
    {
        public double Durchschnittliche_Wortlänge;
        public string[] Eindeutige_Wörter;

        public string[] Fehlerhafte_Wörter;
        public int Anzahl_Wörter { get; set; } 
        public int Anzahl_eindeutiger_Wörter => Eindeutige_Wörter.Length;
        public int Anzahl_fehlerhafter_Wörter => Fehlerhafte_Wörter.Length;
    }
}