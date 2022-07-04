using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeepers
{
    internal class Wolf : IAnimal
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
}
