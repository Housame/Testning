using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TDDInputOutput
{
    public class InputControllers
    {
        Runtime runtime = new Runtime();
        public int NumberController(int n)
        {
            int input = 0;
            do
            {
                Console.Write("nummer {0}: ",n);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch (Exception)
                {
                    //throw new Exception("Skriv in ett nummer");
                    runtime.ClearOneLine();
                    Console.WriteLine("Skriv in ett nummer");
                    Thread.Sleep(800);
                    runtime.ClearOneLine();
                };
                
            } while (true);
        }

        public int NumberDIVISIONController(int v)
        {
            int input = 1;
            do
            {
                Console.Write("nummer {0}: ", v);
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    runtime.ClearOneLine();
                    Console.WriteLine("Skriv in ett nummer");
                    Thread.Sleep(1200);
                    runtime.ClearOneLine();
                };
                if (input == 0 )
                {
                    Console.WriteLine("Det går ej att dela på 0, dags å skicka dej tillbaka till grundskolan kanske!!!");
                    Console.ReadKey();
                    runtime.ClearOneLine();
                    runtime.ClearOneLine();
                }
                else
                    return input;

            } while (true);
        }

        public string FirstNameController()
        {

            do
            {
                Console.Write("Förnamn: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    runtime.ClearOneLine();
                    Console.WriteLine("Var vänlig skriv in ett giltigt namn!!");
                    Thread.Sleep(1000);
                    runtime.ClearOneLine();
                }
            } while (true);

        }

        public string LastNameController()
        {

            do
            {
                Console.Write("Efternam: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    runtime.ClearOneLine();
                    Console.WriteLine("Var vänlig skriv in ett giltigt namn!!");
                    Thread.Sleep(1000);
                    runtime.ClearOneLine();
                }
            } while (true);

        }

    }
}
