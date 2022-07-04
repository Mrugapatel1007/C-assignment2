using System;
namespace Primefactors
{
    public class Factors
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number you want to check : ");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                PrimeFactors(num);
            }
            else
            {
                Console.WriteLine("Invalid input!!");
            }
            Console.ReadKey();
        }

        public static void PrimeFactors(int num)
        {
            Console.Write($"Prime Factors of {num} are : ");


            while (num % 2 == 0)
            {
                Console.Write("2 ");
                num /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write($"{i} ");
                    num /= i;
                }
            }

            if (num > 2)
            {
                Console.Write($"{num} ");
            }
        }
    }
}


