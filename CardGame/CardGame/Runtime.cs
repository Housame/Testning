using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CardGame
{
    class Runtime
    {
        GUI menu = new GUI();
        List<Card> Suits;
        List<Card> Values;
        static string output;
        string FilePath;
        public Runtime()
        {
            #region List of Card Suits
            Suits = new List<Card>()
            {
                new Card { Key = "H", Value = "Hearts"   },
                new Card { Key = "D", Value = "Diamonds" },
                new Card { Key = "C", Value = "Clubs"    },
                new Card { Key = "S", Value = "Spades"   },
            };
            #endregion

            #region List of Card Values
            Values = new List<Card>()
            {
                new Card { Key = "A" , Value = "Ace"   },
                new Card { Key = "2" , Value = "Two"   },
                new Card { Key = "3" , Value = "Three" },
                new Card { Key = "4" , Value = "Four"  },
                new Card { Key = "5" , Value = "Five"  },
                new Card { Key = "6" , Value = "Six"   },
                new Card { Key = "7" , Value = "Seven" },
                new Card { Key = "8" , Value = "Eight" },
                new Card { Key = "9" , Value = "Nine"  },
                new Card { Key = "T",  Value = "Ten"   },
                new Card { Key = "J" , Value = "Jack"  },
                new Card { Key = "Q" , Value = "Queen" },
                new Card { Key = "K" , Value = "King"  },
            };
            #endregion
            #region File Exists or not
            FilePath = String.Format(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\log_file.txt");

            if (!(File.Exists(FilePath)))
                File.Create(FilePath).Close();
            #endregion
        }
        public void Run()
        {
            Console.Clear();
            menu.MainMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    InputMode();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    TestModule();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }

        }

        private void TestModule()
        {
            int index = 1;
            int testPass = 0;
            int testFail = 0;
            string logRow;
            string expectedResult;
            string actualResult;

            List<string> log = new List<string>();

            foreach (var value in Values)
            {
                foreach (var suit in Suits)
                {
                    logRow = String.Empty;

                    expectedResult = value.Value + " of " + suit.Value;
                    actualResult = InputOperation(value.Key + suit.Key);

                    logRow += String.Format("{0} | Input: {1,-10}Expected: {2,-30}Result: {3,-30}",
                        index.ToString("D3"),
                        value.Key + suit.Key,
                        value.Value + " of " + suit.Value,
                        actualResult,
                        "");

                    if (String.Equals(expectedResult, actualResult))
                    {
                        logRow += "PASS";
                        testPass++;
                    }
                    else
                    {
                        logRow += "FAIL";
                        testFail++;
                    }

                    log.Add(logRow);
                    index++;
                }
            }

            File.WriteAllLines(FilePath, log);
            Console.WriteLine("Log file registered.");
            Console.Write("Test results: {0} Pass, {1} Fail", testPass, testFail);
            Console.WriteLine("\n\n-----------------------------------------------");
            Console.Write("Press enter to launch text file...");
            Console.ReadKey();
            Process.Start(FilePath);
        }

        private string InputOperation(string input)
        {
            string result= "";

            if (input.Length == 2 || input.Length == 3 && input.StartsWith("10"))
            {
                if (input.Length == 3 && input.StartsWith("10"))
                {
                    input = input.Replace("10", "T");
                }
                bool validValue = Values
                    .Exists(v => v.Key.Contains(input[0].ToString()));
                bool validSuit = Suits
                    .Exists(s => s.Key.Contains(input[1].ToString()));
                if (validValue && validSuit)
                {
                    result = Values.FirstOrDefault(v => v.Key.Contains(input[0].ToString())).Value;
                    result += " of ";
                    result += Suits.FirstOrDefault(s => s.Key.Contains(input[1].ToString())).Value;
                    
                }
            }

            return result;
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
                    Console.WriteLine(output);
                    Console.Write("\nPress any key...");
                    Console.ReadKey();
                    Run();
                }

            }
        }

        private bool CheckValid(string input)
        {
            bool check = false;
            
            if (input.Length == 2 || input.Length == 3 && input.StartsWith("10"))
            {
                if (input.Length == 3 && input.StartsWith("10"))
                {
                    input = input.Replace("10", "T");
                }
                bool validValue = Values
                    .Exists(v => v.Key.Contains(input[0].ToString()));
                bool validSuit = Suits
                    .Exists(s => s.Key.Contains(input[1].ToString()));
                if (validValue && validSuit)
                { 
                    output = Values.FirstOrDefault(v => v.Key.Contains(input[0].ToString())).Value;
                    output += " of ";
                    output+= Suits.FirstOrDefault(s => s.Key.Contains(input[1].ToString())).Value;
                    check = true;
                }
            }
           
            return check;
        }
    }
}
