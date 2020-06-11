using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        public static void FizzBuzz(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if(number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                FizzBuzz(i);
            }

            Console.ReadLine();
        }
    }
}
