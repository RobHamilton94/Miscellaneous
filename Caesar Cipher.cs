using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare character key
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string message;
            //Get user input
            Console.WriteLine("ENTER MESSAGE");
            message = Console.ReadLine();
            //Using a time complexity of O(N2), loop through each character in the message and check it against the character key.
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        //If the conditions are met then write the character
                        if (j > 2)
                        {
                            Console.Write(alphabet[j - 2]);
                        }
                        else   //If the alphabet goes below A loop it to the end
                        {
                            Console.Write(alphabet[(j + 26) - 2]);
                        }
                    }
                }
                //Preserve space character
                if (message[i] == ' ')
                {
                    Console.Write(message[i]);
                }

            }
            Console.ReadLine();


        }
        
    }
}
