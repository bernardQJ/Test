using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class ReplaceNumbers
    {
        public void Replace()
        {
            for (int i = 1; i < 101; i++)
            {

                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("mareigua");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("mare");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("igua");
                }
                else
                {
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine("\n");
        }

    }
}
