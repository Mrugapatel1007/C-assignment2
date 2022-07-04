using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeepers
{
    internal interface IAnimal
    {
        public static int age { get; set; }
        public static string species { get; set; }
        public static string maneColour { get; set; }

        public static int speed { get; set; }

        public static bool grizzly { get; set; }

    }
}
