using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n to the next line");
            Console.WriteLine("This will \" print out the quatation Mark");

            //Skips a line
            Console.WriteLine();

            string firstName = "Mabhonyoko";
            string lastName = "Mukongo";

            //Concatinating strings
            Console.WriteLine(firstName + " " + lastName);

            //Functions with strings
            Console.WriteLine("The legnth of your lastname is  " + lastName.Length);

            //Methods on strings
            Console.WriteLine(firstName.ToUpper());
            //Method with a parameter(Case sensitive)
            Console.WriteLine(lastName.Contains("Mu"));
            //Access characters using index
            Console.WriteLine(firstName[5]);
            //Takes a variable as an input and returns it's position
            Console.WriteLine("Index of y is ");
            Console.WriteLine(firstName.IndexOf("y")); //Case sensitive;
            //Grabs from an index onwards
            Console.WriteLine(firstName.Substring(1));
            //specify how many characters you wanna bring ,starting from 1
            Console.WriteLine(firstName.Substring(1, 5));
            Console.Read();

        }
    }
}