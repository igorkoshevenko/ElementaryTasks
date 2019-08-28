using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6.LuckyTickets;

namespace UnitTestProject2
{
    [TestClass]
    public class LuckyTicketTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            int expected = 2;


            int x = 100000;
            int b = 100010;
            LuckyTicket ticket = new LuckyTicket(x, b);

            int actual = ticket.Simple();
            Assert.AreEqual(expected, actual);
        }
    }
}
