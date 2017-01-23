using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDInputOutput
{
    public class Manager
    {
        public string NameInputer(string x, string y)
        {
            //return "Housame Oueslati";
            return x + " " + y;
        }

        public int AdditionInputer(int v1, int v2)
        {
            //return 15;
            return v1 + v2;
        }

        public int SubtractionInputer(int v1, int v2)
        {
            //return 23;
            return v1 - v2;
        }

        public int MultiplicationInputer(int v1, int v2)
        {
            //return 100;
            return v1 * v2;
        }

        public int DivisionsInputer(int v1, int v2)
        {
            //return 17;
            return v1 / v2;
        }

        public bool FileChecker(string text)
        {
            //return true;
            bool result = true;
            if (File.Exists(text))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public void WriteToTxt(string personLine,string path)
        {
            
                if ((FileChecker(path) == true))
                {
                    File.AppendAllText(path, personLine);
                    
                }
                else
                {
                    File.Create(path);
                    File.AppendAllText(path, personLine);
                }
            Console.WriteLine("Klart");
            Console.WriteLine("{0} är lagt i din text fil!!!");
            Console.ReadKey();
        }
    }
}
