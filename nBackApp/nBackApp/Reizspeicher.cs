using System;
using System.Threading;

namespace nBackApp
{
    public class Reizspeicher
    {
        public readonly char[] Reize;

        public int Index { get; private set; }

        public int Anzahl => Reize.Length;
   

        public Reizspeicher(char[] reize)
        {
            this.Reize = reize;
            Index = 0;
        }

        public void Nächster(Action<char> nächsterReiz, Action ende)
        {
            if (Index < Reize.Length)
            {
                nächsterReiz(Reize[Index]);
                Index++;
            }
            else
                ende();
        }
    }
}