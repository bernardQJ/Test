using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ReplaceNumbers replace = new ReplaceNumbers();
            replace.Replace();

            Numbers numbers = new Numbers();
            numbers.Number();

            InvertSentence words = new InvertSentence();
            words.Sentence();
        }
                  
    }
}
