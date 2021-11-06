using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class TestLits
    {
        public void listTest()
        {
            List<int> t;
            t = Enumerable.Range(1, 100).ToList();

            var mareigua = t.Where(num => num % 3 == 0 && num % 5 == 0);
            var mare = t.Where(num => num % 3 == 0);
            var igua = t.Where(num => num % 5 == 0);
            var notFizzBuzz = t.Where(num => num % 3 != 0 && num % 5 != 0);

            //print fizzBuzz elements
            Console.WriteLine("mareigua");
            foreach (int i in mareigua)
                Console.WriteLine(i);

            //print fizz elements
            Console.WriteLine("mare...");
            foreach (int i in mare)
                Console.WriteLine(i);

            //print buzz elements
            Console.WriteLine("igua...");
            foreach (int i in igua)
                Console.WriteLine(i);

            //print other elements
            Console.WriteLine("Printing all others...");
            foreach (int i in notFizzBuzz)
                     Console.WriteLine(i);
           // Response.Write(i + ",");
            Console.WriteLine("Hello World!");
        }
    }
}
