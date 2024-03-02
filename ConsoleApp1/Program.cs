using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
            Console.Write("Enter Your Namber: ");
            int number = int.Parse(Console.ReadLine());

            string output = "";

            if (number % 3 == 0)
            {
                output += "Hello";
            }
            if (number % 5 == 0)
            {
                output += "World";
            }
            if (number % 7 == 0)
            {
                output += "My";
            }

            if (output == "")
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(output);
            }

            }
        }
    }
}
