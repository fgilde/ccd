using System;
using System.IO;

namespace Questionnaire.Adapter
{
    public class DateiSystem
    {
        public string[] Lese_Datei_Zeilenweise()
        {
            return File.ReadAllLines("questionnaire.txt");
        }
    }
}