using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeepers
{
    internal class Bear : IAnimal
    {
        public static int age { get; set; }
        public static string species { get; set; }
        public static bool grizzly { get; set; }

        public void bear()
        {
            Console.Write("Cage 3\nWhat is the Animal's species? ");
            species = string.Concat(Console.ReadLine());

            Console.Write("How Old is it? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Is it grizzly bear (true/false)? "); // we can put Yes/No insted of True/False here.
            grizzly = Convert.ToBoolean(Console.ReadLine());

        }
    }
}

