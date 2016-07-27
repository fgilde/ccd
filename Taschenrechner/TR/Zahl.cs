namespace TR
{
    public class Zahl
    {
        public int Wert { get; private set; }

        public Zahl()
        {
            Zurücksetzen();
        }

        public void Zurücksetzen()
        {
            Wert = 0;
        }

        public void Erweitern(char ziffer)
        {
            Wert = int.Parse(Wert.ToString() + ziffer);
        }
    }
}