using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricSeries();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        static void GeometricSeries()
        {
            Console.Write("a= ");
            int iTerm = int.Parse(Console.ReadLine());

            Console.Write("r = ");
            int iRatio = int.Parse(Console.ReadLine());

            Console.Write("n = ");
            int iNum = int.Parse(Console.ReadLine());

            double dSum = 0;

            for (int i = 0; i < iNum; i++)
            {
                dSum += iTerm;
                iTerm *= iRatio;
            }
            Console.WriteLine("\nSum of geometric series : " + dSum.ToString());
        } 
    }
}
