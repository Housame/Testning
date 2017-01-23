using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExxeptionTestPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            do
            {
                result = Run();
            } while (result);
        }

        private static bool Run()
        {
            //Täljare
            int dominator;
            //Nämnare
            int numerator;
            bool functionResult = false;
            try
            {
                Console.Clear();
                Console.WriteLine("Division: _/x");
                dominator = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Division: {0}/_",dominator);
                numerator = int.Parse(Console.ReadLine());
                Console.Clear();
                double result = SafeDivide(dominator, numerator);
                Console.WriteLine("Division: {0}/{1}= {2}", dominator,numerator,result);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException||ex is OverflowException||ex is System.IO.IOException||ex is FormatException|| ex is ArgumentNullException  )
                {
                    Console.WriteLine("Invalid iput",ex.Message);
                }
                else if(ex is NullDominatorException)
                {
                    Console.WriteLine("Division by zero: {0}",ex.Message);
                }
            }
            finally
            {
                dominator = 0;
                numerator = 0;
                //Console.Clear();
            }
            functionResult = true;
            Console.ReadKey();
            return functionResult;
        }

        private static double SafeDivide(int a, int b)
        {
            if (b == 0)
            {
                throw new NullDominatorException("Exception Message From SafeDivide()");
            }
            return  a / b;
        }

        public class NullDominatorException : Exception
        {
            public override string Message
            {
                
                get
                {
                    return "Exception fo division By zero";
                }
                
            }
            
            public NullDominatorException() : base()
            {

            }
            public NullDominatorException(string message) : base(message)
            {
                
            }
            public NullDominatorException(string message, Exception inner):base(message,inner)
            {

            }
        }
    }
}
