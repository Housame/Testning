using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HousameOueslatiLabb1
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            double x = 0;

            do
            {
                Console.WriteLine(" 1 / x = ?");
                line = Console.ReadLine();

                try
                {
                    x = double.Parse(line);
                    if (x == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Error");
                    }

                    else if (x.GetType() == typeof(double))
                    {
                        x = 1 / x;
                        Console.WriteLine(" 1 / x = {0}", x);
                        Thread.Sleep(1000);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Error");
                }

                

            } while (true);

            

        }
    }
}
