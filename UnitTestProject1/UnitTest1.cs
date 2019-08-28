using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.FileParser;

namespace UnitTestProject1
{
    [TestClass]
    public class FileParserTest
    {
        [TestMethod]
        public void ReadFileTest()
        {
            string expected = "abbccc";
            FileParser f = new FileParser("1.txt", "a");
            string actual = f.ReadFile();
            Assert.AreEqual(expected, actual);

        }
    }
}
