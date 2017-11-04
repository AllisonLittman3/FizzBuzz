using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //For numbers 1 through 100, print "Fizz" if divisible by 3, print "Buzz" if divisible by 5, print "Fizz Buzz" if divisible by both.
            //I've also included the non-Fizz Buzz numbers to showcase accuracy.

            for (int i = 1; i < 101; i++)
                if (i % 3 == 0 && i % 5 == 0) //if the number is divisible by both 3 and 5 write "Fizz Buzz"
                    Console.WriteLine("Fizz Buzz");
                else if (i % 3 == 0) //if the number is divisible by 3 write "Fizz"
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0) //if the number is divisible by 5 write "Buzz"
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i); //all other numbers

            Console.ReadLine();
        }
    }
}
