using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            double quotient;
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero");
            }
            else
            {
                quotient = x / y;
            }

            return quotient;
        }

        //static int CheckFileExtension(string fileName)
        //{
        //    // Write your code here!
        //}


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(34, 0));
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("You can't divide by zero.");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


        }
    }
}
