using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sped
{
    class Program
    {
        static void Main(string[] args)
        {
            string light = "";
            Console.WriteLine("Please enter 1 for on, 0 for off and q to quit.");
            while (light != "stop")
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        light = "on";
                        break;
                    case "0":
                        light = "off";
                        break;
                    case "q":
                        light = "stop";
                        break;
                    default:
                        Console.WriteLine("what?? Please enter again.");
                        break;
                }
                Console.WriteLine("The light is {0}.", light);
            }
            Console.WriteLine("...Stoping Program.");
            Console.ReadKey();
        }
    }
}
