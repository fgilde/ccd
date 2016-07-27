using System.Collections.Generic;

namespace nBackApp
{
    public class SpielStand
    {
        public Profil Profil { get; private set; }
        private readonly List<char> antworten;

        public SpielStand(Profil profil)
        {
            Profil = profil;
            antworten = new List<char>();
        }

        public void AntwortMerken(char c)
        {
            antworten.Add(c);
        }

        public char[] AlleAntworten()
        {
            return antworten.ToArray();
        }
    }
}