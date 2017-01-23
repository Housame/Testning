#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
// DO NOT CHANGE
namespace NumberSystemConverter
{
    class Program
    {
        static RomanNumeralConverter converter;

        static void Main(string[] args)
        {
            converter = new RomanNumeralConverter();
            Run();
        }

        static void Run()
        {
            /*Runs the program expecting only integral inputs and calls ConvertToRomanNumeral() upon receiving*/
            while (true)
            {
                //int result;
                Console.WriteLine("Numeral Registry");
                Console.WriteLine("Acceptable Values     |     Non-Acceptable Values");
                Console.WriteLine("M - 1000              |     (D, L, I, X, V) + M");
                Console.WriteLine("D - 500               |     (L, X, V, I) + D");
                Console.WriteLine("C - 100               |     (L, V, I) + C");
                Console.WriteLine("L - 50                |     (V, I) + L");
                Console.WriteLine("X - 10                |     ");
                Console.WriteLine("V - 5                 |     ");
                Console.WriteLine("I - 1                 |     (I) + I + I + I + I\n");

                Console.WriteLine("Please enter an integer value OR roman numeral to be converted...");
                string userInput = Console.ReadLine();

                try
                {
                    
                     SafePassage(userInput.ToUpper());

                }
                catch (Exception ex)
                {

                    if (ex is InvalidOperationException)
                        Console.WriteLine(ex);
                }

                Console.Write("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void SafePassage(string userInput)
        {
            string[] eiwa = { "DM", "LM", "IM", "XM", "VM", "LD", "XD", "VD", "ID", "LC", "VC", "IC", "VL", "IL", "IIII" };
            if (userInput.All(c => c > '0' && c <= '9') && userInput != "")
            {
                if (int.Parse(userInput) > 5000)
                    throw new InvalidOperationException();
                
                else
                    Console.WriteLine(userInput + " = " + converter.ConvertToRomanNumeral(int.Parse(userInput)));
            }
            else if (userInput == "")
                throw new InvalidOperationException();
            else if (userInput.All(c => c == 'M' || c == 'D' || c == 'C' || c == 'L' || c == 'X' || c == 'V' || c == 'I') && !eiwa.Any(c => userInput.Contains(c)))
            {
                Console.WriteLine(userInput + " = " + converter.ConvertFromRomanNumeral(userInput.ToCharArray().Select(c => c.ToString()).ToArray()));
            }
            else if (eiwa.Any(c => userInput.Contains(c)))
            {
                throw new InvalidOperationException();
            }
            
            else throw new InvalidOperationException();
        }

        public class InvalidOperationException : Exception
        {
            public override string Message
            {

                get
                {
                    return "Exception for DM, LM, IM, XM, VM , LD, XD , VD, ID, LC, VC, IC, VL , IL, IIII";
                }

            }
        }
    } 
}
