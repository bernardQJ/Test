using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class InvertSentence
    {
        public void Sentence()
        {
            Console.Write("ingrese frase o palabra a invertir : \n ");

            string frase = (Console.ReadLine());
            StringBuilder cadena = new StringBuilder(frase);
            Console.WriteLine(Invertir(cadena));
        }

        static StringBuilder Invertir(StringBuilder cadena, int cont = 0)
        {
            char temp;

            if (cont == cadena.Length / 2)
            {
                return cadena;
            }
            else
            {
                temp = cadena[cont];
                cadena[cont] = cadena[cadena.Length - 1 - cont];
                cadena[cadena.Length - 1 - cont] = temp;

                return Invertir(cadena, cont + 1);
            }

        }
    }
}
