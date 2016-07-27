using System;

namespace TR
{
    public class Rechner
    {
        private char @operator;

        public Rechner()
        {
            @operator = '+';
        }

        private void Berechne(int zahl, Action<int> onSuccess, Action<string, int> onError)
        {
            
        }

        public void Berechne(char op, int zahl, Action<int> onSuccess, Action<string, int> onError)
        {
            Berechne(zahl, onSuccess, onError);
            @operator = op;
        }
    }
}
