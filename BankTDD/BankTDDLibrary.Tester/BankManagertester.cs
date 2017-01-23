using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace BankTDDLibrary.Tester
{
    [TestFixture]
    public class BankManagertester
    {
        [Test]
        public void WithDraw_More_Than_Saldo()
        {
            BankManager mgr = new BankManager();
            int exceptedOutput = -1;
            int actualOutput = mgr.Debit(11000);
            Assert.AreEqual(exceptedOutput, actualOutput, "A withdraw is not allowed, contact your bank or get a job.");
        }
        ////[Test, ExpectedException(typeof(FormatException))]
        //[Test]
        ////[ExpectedException("System.InvalidOperationException") ]
        //public void WithDraw_More_Than_Saldo()
        //{
        //    BankManager mgr = new BankManager();
        //    mgr.Debit(11000);
        //    Assert.Fail("A withdraw is not allowed, contact your bank or get a job.");
        //    //Assert.That(Throws.TypeOf<InvalidOperationException>());
        //}

        [Test]
        public void Draw_1000()
        {
            BankManager mgr = new BankManager();
            int exceptedSaldo = mgr.Saldo -1000;
            int actualSaldo = mgr.Debit(1000);
            Assert.AreEqual(exceptedSaldo, actualSaldo);
        }

       

        [Test]
        public void Add_1000()
        {
            BankManager mgr = new BankManager();
            int exceptedSaldo = mgr.Saldo + 1000;
            int actualSaldo = mgr.Credit(1000);
            Assert.AreEqual(exceptedSaldo, actualSaldo);
        }

        [Test]
        public void Balance_1000()
        {
            BankManager mgr = new BankManager();
            int exceptedSaldo = mgr.Saldo;
            int actualSaldo = mgr.Balance();
            Assert.AreEqual(exceptedSaldo, actualSaldo);
        }
    }
}
