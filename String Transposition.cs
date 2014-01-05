using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Transposition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialise a list to store each string
            IList<String> listOfStrings = new List<string>();
            //Ask for user input
            Console.WriteLine("How many strings will there be?");
            int numberOfStrings = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfStrings; i++)
            {
                listOfStrings.Add(Console.ReadLine());
            }
            int longestString = listOfStrings.Select(x => x.Length).Max();
            for (int row = 0; row < longestString; row++)
            {
                foreach (String stringFromList in listOfStrings)
                {
                    if (stringFromList.Length > row)
                    {
                        Console.Write(stringFromList[row]);
                    }else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
