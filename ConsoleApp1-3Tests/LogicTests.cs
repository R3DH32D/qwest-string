using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void RearrangementTest1()
        {
            string word = "abcd";
            var outPut = "";
            var message = Logic.Rearrangement(word, outPut);
            Assert.AreEqual("badc", message);
        }
        [TestMethod()]
        public void RearrangementTest2()
        {
            string word = "abcde";
            var outPut = "";
            var message = Logic.Rearrangement( word, outPut);
            Assert.AreSame("Введено неверное слово, перезапустите программу и повторите попытку", message);
        }
    }
}