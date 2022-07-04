using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeepers
{
    // WE CAN PUT ALL CLASSES HERE TOO.
    // Interface
    /*public interface IAnimal
    {

    }

    class Lion : IAnimal
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

    class Wolf : IAnimal
    {
        public static int age { get; set; }
        public static string species { get; set; }
        public static int speed { get; set; }

        public void wolf()
        {
            Console.Write("Cage 2\nWhat is the Animal's species? ");
            species = string.Concat(Console.ReadLine());

            Console.Write("How Old is it? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("How fast can it run (in km/h)? ");
            speed = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Bear : IAnimal
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
    }*/

    class Program
    {
        List<IAnimal> animal = new List<IAnimal>();
        static void Main(string[] args)
        {
            RequestUniqueCharacteristic();
            getdescription();
        }

        private static void getdescription()
        {
            Console.WriteLine("=====");
            Console.WriteLine("Cage 1 contains a {0}-years-old {1} with a {2} mane.", Lion.age, Lion.species, Lion.maneColour);
            Console.WriteLine("Cage 2 contains a {0}-years-old {1} that runs {2} km/h.", Wolf.age, Wolf.species, Wolf.speed);
            string grizzly = "";
            if (Bear.grizzly == false)          // we can put Yes/No insted of True/False here.
            {
                grizzly = "Non-";
            }
            else if (Bear.grizzly == true)
            {
                grizzly = "";
            }
            Console.WriteLine("Cage 3 contains a {0}-years-old {1} {2}grizzly bear.", Bear.age, Bear.species, grizzly);

            Console.ReadLine();
        }

        public static void RequestUniqueCharacteristic()
        {
            Lion lion = new Lion();
            lion.lion();

            Wolf wolf = new Wolf();
            wolf.wolf();

            Bear bear = new Bear();
            bear.bear();
        }
    }
}

