using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TDDInputOutput
{
    public class Runtime
    {
        string path = @"C: \Users\acer pc\Desktop\Plugget\Testning av programvara\TDDInputOutput\Text.txt";
       public void Start()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Lägg till:");
                Console.WriteLine("2. Läsa texten:");
                Console.WriteLine("3. Avsluta:");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Add();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Read();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("1 ,2 ellllllller 3!!!!");
                        Thread.Sleep(1000);
                        ClearOneLine();
                        break;

                }
            }
            
        }

        private void Read()
        {
            Console.Clear();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        private void Add()
        {
            Console.Clear();
            Person person = new Person();
            Manager mgr = new Manager();
            InputControllers iptCon = new InputControllers();
            string n1 = iptCon.FirstNameController();
            string n2 = iptCon.LastNameController();
            person.Name = mgr.NameInputer(n1, n2);
            Console.WriteLine("2 nummer för addition: ");            
            int x1 = iptCon.NumberController(1);
            int x2 = iptCon.NumberController(2);
            person.SumAdd = mgr.AdditionInputer(x1, x2);
            Console.WriteLine("2 nummer för Subtraktion: ");
            int y1 = iptCon.NumberController(1);
            int y2 = iptCon.NumberController(2);
            person.SumSub = mgr.SubtractionInputer(y1, y2);
            Console.WriteLine("2 nummer för multiplikation: ");
            int z1 = iptCon.NumberController(1);
            int z2 = iptCon.NumberController(2);
            person.SumMulti = mgr.MultiplicationInputer(z1, z2);
            Console.WriteLine("2 nummer för division: ");
            int t1 = iptCon.NumberController(1);
            int t2 = iptCon.NumberDIVISIONController(2);
            person.SumDiv = mgr.DivisionsInputer(t1, t2);
            string personLine = person.Name + ", " + person.SumAdd + ", " + person.SumSub + ", " + person.SumMulti + ", " + person.SumMulti + ";" + Environment.NewLine;

            mgr.WriteToTxt(personLine, path);
        }

        public void ClearOneLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

    }
}
