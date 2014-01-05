using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string unformattedperimeter;
            string unformattedseams;
            float perimeter;
            float seams;
            //Standard price per patch
            int patchcost = 70;
            //Standard material cost per metre of edgelength
            double materiallinearcost = 16.25;
            double cablelinearcost = 3.83;
            //Ask user for input
            Console.WriteLine("Please enter the perimeter.");
            unformattedperimeter = Console.ReadLine();
            Console.WriteLine("Please enter the seams.");
            unformattedseams = Console.ReadLine();
            //convert strings to floats
            float.TryParse(unformattedperimeter, out perimeter);
            float.TryParse(unformattedseams, out seams);
            //
            float totalmeterage = perimeter + seams;
            double materialcost = totalmeterage * materiallinearcost;
            double materialpatch = materialcost + patchcost;
            //Now work out the total price for the cable
            double cablecost = perimeter * cablelinearcost;
            double finalprice = materialpatch + cablecost;
            //Display finap price to the user
            Console.WriteLine("The final price is " + finalprice);
            Console.ReadLine();
        }
    }
}
