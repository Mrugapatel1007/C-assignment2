using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeepers
{
    internal class Lion : IAnimal
    {
        public static int age { get; set; }
        public static string species { get; set; }
        public static string maneColour { get; set; }

        public void lion()
        {
            Console.Write("Cage 1\nWhat is the Animal's species? ");
            species = string.Concat(Console.ReadLine());

            Console.Write("How Old is it? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("What colour is its mane? ");
            maneColour = string.Concat(Console.ReadLine());
        }
    }
}
