using System;
using System.Linq;

namespace nBackApp
{
    public class ReizMacher
    {
        private static Random random = new Random();

        //private static readonly char[] reize = {'A','B','C','A','T', 'D', 'A', 'X', 'Y', 'A' };

        public static char[] ReizeBerechnen(int anzahlReize, int n)
        {
            char[] reize = ZufälligenBuchstabenSalatErzeugen(anzahlReize);
            int anzahlNBacks = AnzahlNBacksFestlegen(anzahlReize, n);
            reize = NBacksVerteilen(anzahlReize, anzahlNBacks, reize, n);

            return reize;
        }

        private static char[] NBacksVerteilen(int anzahlReize, int anzahlNBacks, char[] reize, int n)
        {
            int[] indizes = PositionenErmitteln(anzahlReize, anzahlNBacks, n);
            reize = ReizeÄndern(reize, indizes, n);
            return reize;
        }

        private static int[] PositionenErmitteln(int anzahlReize, int anzahlNBacks, int n)
        {
            int[] indizes = new int[anzahlNBacks];
            for (int i = 0; i < indizes.Length; i++)
            {
                indizes[i] = random.Next(n, anzahlReize);
            }
            return indizes.Distinct().OrderByDescending(i => i).ToArray();
        }

        private static char[] ReizeÄndern(char[] reize, int[] indizes, int n)
        {
            foreach (var index in indizes)
            {
                reize[index - n] = reize[index];
            }
            return reize;
        }

        private static int AnzahlNBacksFestlegen(int anzahlReize, int n)
        {
            int maximalAnzahlNBacks = (int)((anzahlReize - n) * 0.8);
            int anzahlNBacks = random.Next(1, maximalAnzahlNBacks);
            return anzahlNBacks;
        }

        private static char[] ZufälligenBuchstabenSalatErzeugen(int anzahlReize)
        {
            char[] reize = new char[anzahlReize];
            for (int i = 0; i < reize.Length; i++)
            {
                reize[i] = (char)random.Next('A', 'Z');
            }
            return reize;
        }
    }
}