using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj liczbę");
            //FizzBuzz buzz = new FizzBuzz();
            //Console.WriteLine(buzz.Translate(int.Parse(Console.ReadLine())));
            //Console.Read();
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if(number%3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (number%3==0 && number%5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //if (number<0)
            //{
            //    throw ArgumentException;
            //}
            if (number % 3 != 0 || number % 5 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
