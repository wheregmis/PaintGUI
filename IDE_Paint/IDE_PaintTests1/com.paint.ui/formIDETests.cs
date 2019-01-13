using Microsoft.VisualStudio.TestTools.UnitTesting;
using IDE_Paint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDE_Paint.com.paint.ui;
using System.Windows.Forms;
using IDE_Paint.com.paint.factory;
using IDE_Paint.com.paint.shapes;
using System.Drawing;

namespace IDE_Paint.Tests
{
    [TestClass()]
    public class formIDETests
    {
        [TestMethod()]
        public void WrongParameterTest()
        {
            
                String command = "Draw rectangle 20s,20 on 10,10";
                formIDE ide = new formIDE();
                Assert.AreEqual(false, ide.SyntaxValidating(command));
               
        }
        [TestMethod()]
        public void ParameterTest()
        {

            String command = "Draw rectangle 20,20 on 10,10";
            formIDE ide = new formIDE();
            Assert.AreEqual(true, ide.SyntaxValidating(command));

        }
        [TestMethod()]
        public void WrongCommandTest()
        {

            String command = "Draw rctangle 20,20 on 10,10";
            formIDE ide = new formIDE();
            Assert.AreEqual(false, ide.SyntaxValidating(command));

        }
        [TestMethod()]
        public void CommandTest()
        {

            String command = "Draw rectangle 20,20 on 10,10";
            formIDE ide = new formIDE();
            Assert.AreEqual(true, ide.SyntaxValidating(command));

        }

        [TestMethod()]
        public void getRectangleTest() {
            
         IShape shape3 = ShapeFactory.getShape("RECTANGLE");
         Assert.AreEqual(new SRectangle().ToString(), shape3.ToString());
            
        }

        [TestMethod()]
        public void getCircleTest()
        {
            IShape shape3 = ShapeFactory.getShape("ELLIPSE");
            Assert.AreEqual(new SEllipse().ToString(), shape3.ToString());
        }

        [TestMethod()]
        public void getCubeTest()
        {
            IShape shape3 = ShapeFactory.getShape("CUBE");
            Assert.AreEqual(new SCube().ToString(), shape3.ToString());
        }
        [TestMethod()]
        public void getTriangleTest()
        {
            IShape shape3 = ShapeFactory.getShape("TRIANGLE");
            Assert.AreEqual(new STriangle().ToString(), shape3.ToString());
        }

        [TestMethod()]
        public void getPolygonTest()
        {
            IShape shape3 = ShapeFactory.getShape("POLYGON");
            Assert.AreEqual(new SPolygon().ToString(), shape3.ToString());
        }

        [TestMethod()]
        public void getTextureTest()
        {
            IShape shape3 = ShapeFactory.getShape("TEXTURE");
            Assert.AreEqual(new STexture().ToString(), shape3.ToString());
        }

    }
}