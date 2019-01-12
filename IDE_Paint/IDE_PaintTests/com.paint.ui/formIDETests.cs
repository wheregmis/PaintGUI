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
        public void formIDETest()
        { 

            
        }
        [TestMethod()]
        public bool SyntaxCheckerTest() {
            formIDE ide = new formIDE();
            String command = "Draw retangle 20,20 on 10,10";
           return ide.SyntaxChecker(command);

        }
    }
}