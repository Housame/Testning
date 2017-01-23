using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittFunProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.0;
            double y = 1.0;

  testc:          
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                y = 0;
                Console.WriteLine(e.Message);
                goto testc;
            }
            try
            {
                x/=y;
            }
            catch (DivideByZeroException e)
            {
                y = 0;
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(x);
            Console.ReadKey(true);
        }
    }
}
