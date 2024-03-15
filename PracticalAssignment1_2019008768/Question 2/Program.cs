using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question2
{
    //2019008768
    //Ramaru Rotondwa
    //Practical Assignment 1 
    // Question 1
    class cProgram
    {
        static void Main(string[] args)
        {
            decimal mAmount = 0;
            double dRate = 0;
            int iPeriods = 0;

            Getinput( ref mAmount,ref dRate,ref iPeriods);
            OutPut(ROI(mAmount, dRate, iPeriods));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void Getinput(ref decimal mAmount, ref double dRate, ref int iPeriods)
        {
            Console.Write("Initial amount       : R ");
            mAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Interest rate (%)    : ");
            dRate = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Periods              : ");
            iPeriods = int.Parse(Console.ReadLine());
        }

        static decimal ROI( decimal _mAmount, double _dRate, int _iPeriods)
        {
            decimal mROI = _mAmount * (decimal)(Math.Pow(1 + _dRate, _iPeriods));
            return mROI;
        }
        static void OutPut(decimal _mROI)
        {
            Console.WriteLine("Return on investment : R " + _mROI.ToString("0.00"));
        }
    }
}
