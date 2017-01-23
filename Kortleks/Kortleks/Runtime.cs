using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kortleks
{
   struct Card
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    List<Card> Suits = new List<Card>();
    List<Card> Values = new List<Card>();
    public class Runtime
    {
        Menus menu = new Menus();
        public void Run()
        {
            menu.MainMenu();
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    InputMode();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    //TestModule();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }
            
        }
        public void InputMode()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter your card");
                var input = Console.ReadLine().ToUpper();
                if (CheckValid(input) == false)
                {
                    Console.WriteLine("Invalid input");
                    Thread.Sleep(1000);
                }
                else if (CheckValid(input) == true)
                {
                    Console.WriteLine(Converter(input));
                    Console.Write("\nPress any key...");
                    Console.ReadKey();
                    Run();
                }

            }
        }

        public string Converter(string input)
        {
            string result = " ";
            if (input.Length == 2)
            {
                result = string.Format("{0} of {1}",input[0],StringConverter(input[1]));
            }
            else if (input.Length == 3)
            {
                result = string.Format("10 of {0}", StringConverter(input[2]));
            }
            return result;
        }

        public string StringConverter(char v)
        {
            string result = " ";
            if (v == 'S')
                result = "Spades";
            else if (v == 'H')
                result = "Hearts";
            else if (v == 'D')
                result = "Diamonds";
            else if (v == 'C')
                result = "Clubs";
            return result;
        }

        public bool CheckValid(string input)
        {
            bool check = false;
            if (input.Length < 2 && input.Length > 3)
            {
                check = false;
            }
            else if (input.Length==2)
            {  
                var firstChar = input[0];
                var secondChar = input[1];
                if (Check_First_Digit(firstChar) && Check_Second_Digit(secondChar))
                    check = true;
            }
            else if (input.Length==3)
            {
                if (input.Equals("10S") || input.Equals("10H") || input.Equals("10D") || input.Equals("10C") )
                    check = true;
            }
            return check;
        }

        private bool Check_Second_Digit(char secondChar)
        {
            bool result = false;
            if (secondChar == 'S' || secondChar == 'D' || secondChar == 'H' || secondChar == 'C')
                result = true;
            return result;
        }

        public bool Check_First_Digit(char firstChar)
        {
            bool result = false;
            if ((firstChar >= '2' && firstChar <= '9') || firstChar == 'K' || firstChar == 'Q' || firstChar == 'A')
                result = true;
            return result;
        }
    }
}
