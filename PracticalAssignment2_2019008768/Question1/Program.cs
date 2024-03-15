using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2019008768
//Ramaru Rotondwa
//Practical Assignment 2
//Question 1.1

namespace Question1
{
    class cProgram
    {
        static void Main(string[] args)
        {
            char cDegree = (char)0176;
            double dFahrenheit = 0.00;
            double dCelsius = 0.00;

            try
            {
                Console.Write("Enter the temperature in " + cDegree + "F: ");
                dFahrenheit = double.Parse(Console.ReadLine());

                dCelsius = 5.0 / 9 * (dFahrenheit - 32);

                Console.WriteLine("\n" + dFahrenheit.ToString("") + cDegree + "F = " + dCelsius.ToString("0.00") + cDegree + "C");
            }
            catch
            {
                Console.WriteLine("\nInvalid input was entered. The application will now exit.");
            }

            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();
        }
    }
}
