using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("Passwords.txt")) //Initialise a new streamwriter to save the passwords to a text file
            {
                //Initialise Random as a variable
                Random r = new Random();
                //Ask for user input
                Console.WriteLine("How many characters long do you want your password?");
                int passwordlength = int.Parse(Console.ReadLine());
                Console.WriteLine("How many passwords would you like to generate?");
                int passwordquantity = int.Parse(Console.ReadLine());
                //Using a time complexity of O(N^2), loop through the number of characters wanted, by the number of passwords wanted
                for (int i = 0; i < passwordquantity; i++)
                {
                    string password = "";
                    for (int j = 0; j < passwordlength; j++)
                    {
                        password += Convert.ToString((char)r.Next(33, 127));
                    }
                    Console.WriteLine(password);    //start a new line for the next password
                    sw.WriteLine(password);         //write the new password to the text file "Passwords.txt"   
                }
                Console.ReadLine();
            }
        }
    }
}
