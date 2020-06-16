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

        static int CheckFileExtension(string fileName)
        {
            if (fileName.Equals("") || fileName.Equals(null))
            {
                throw new FormatException("Filename is empty.");
            }
            else if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(34, 0));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(student.Value));
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
