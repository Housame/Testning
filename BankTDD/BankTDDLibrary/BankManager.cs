using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankTDDLibrary
{
    
    public class BankManager
    {
        public int Saldo = 10000;
        public int Debit(int input)
        {
            if (Saldo < input)
            {
                //throw new InvalidOperationException("A withdraw is not allowed, contact your bank or get a job.");
                return -1;
            }
            else
                return Saldo - input;
            
        }
        public int Credit(int input)
        {
            return Saldo + input;
        }
        public int Balance()
        {
            return Saldo;
        }
    }
}
