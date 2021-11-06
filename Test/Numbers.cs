using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Numbers
    {
        public void Number()
        {
            int[] numbers = new int[10];
            //contador
            int n;
            Console.Write("Por favor ingrese 10 números enteros positivos, extraeremos el mayor y el menor entre ellos: \n ");
            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            int max = numbers[0], min = numbers[0];
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] > max)

                    max = numbers[i];

                else if (numbers[i] < min)

                    min = numbers[i];
            }

            Console.Write("\n\nel número mayor es: " + max);
            Console.Write("\n\nel número menor es: " + min);
            Console.WriteLine("\n"); 
            //Console.readkey();

        }
    }
}
