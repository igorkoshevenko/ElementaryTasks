using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6.LuckyTickets;

namespace UnitTestProject3
{
    [TestClass]
    public class LuckyTicketTest
    {
        [TestMethod]
        public void DifficultTest()
        {
            int expected = 0;


            int x = 100000;
            int b = 100010;
            LuckyTicket ticket = new LuckyTicket(x, b);

            int actual = ticket.Difficult();
            Assert.AreEqual(expected, actual);
        }
    }
}
