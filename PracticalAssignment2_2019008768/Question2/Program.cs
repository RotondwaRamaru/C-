using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2019008768
//Ramaru Rotondwa 
//Practical Assignment 2 
//Question 2 

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iSum = 0;
            int iNumber = 0;

            Console.Write("Enter a positive integer: ");
            iNumber = int.Parse(Console.ReadLine());

            iSum = GetCategory(iNumber, iSum);
            Console.Write("\nThe sum of the proper divisors of " + iNumber.ToString() + " is ");
            Console.Write(iSum.ToString());

            if (iSum > iNumber)
            {
                Console.Write("\nTherefore it is abundant. ");
            }
            else if (iSum < iNumber)
            {
                Console.Write("\nTherefore it is deficient. ");
            }
            else if (iSum == iNumber)
            {
                Console.Write("\nTherefore ie is a perfect number. ");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
        static int GetCategory(int _iNumber, int _iSum)
        {
            int iResults = 0;

            for (int Devisor = 1; Devisor < _iNumber; Devisor++)
            {
                if ((_iNumber % Devisor) == 0)
                {
                    _iSum += Devisor;
                }
            }
            return iResults = _iSum;
        }
    }
}
