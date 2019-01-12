using Microsoft.VisualStudio.TestTools.UnitTesting;
using IDE_Paint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Paint.Tests
{
    [TestClass()]
    public class formIDETests
    {
        [TestMethod()]
        public void SyntaxCheckerTest()
        {
            try
            {
                String command = "Draw retangle 20,20 on 10,10";
                formIDE ide = new formIDE();
                // Boolean test =  ide.SyntaxChecker(command);
                Boolean test = false;
                if (test == false) {
                    throw new Exception("Syntax Error");
                }
            }
            catch(Exception e) {
                StringAssert.Contains(e.Message, "Syntax Error");
            }

            Assert.Fail("No exception was thrown");
        }
    }
}