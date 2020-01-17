using System;
using ASE_Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Moveto_Test_Right()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("moveto 10 10");
            Assert.AreEqual(result[0], "moveTo", result[1], "10", result[2], "10");

        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Moveto__Test_Wrong()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("moveto 10");
            Assert.AreEqual(result[0], "10");
        }

        [TestMethod]
        /*public void Drawto_Test_Right()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("drawto 20 30");
            Assert.AreEqual(result[0], "drawto", result[1], "20", result[2], "30");

        }
        [TestMethod]
        public void Drawto__Test_Wrong()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("drawto 20");
            Assert.AreEqual(result[0], "1");
        }
*/

        
        public void Rectangleto_Test_Right()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("rectangle 20 30");
            Assert.AreEqual(result[0], "rectangle", result[1], "20", result[2], "30");

        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Rectangleto__Test_Wrong()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("rectangle 20");
            Assert.AreEqual(result[0], "rectangle", result[1], "20");
        }

        [TestMethod]
        public void Cirle_Test_Right()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("circle 10");
            Assert.AreEqual(result[0], "circle", result[1], "10");

        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Circle__Test_Wrong()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("circle 50 50");
            Assert.AreNotSame(result[0], "1");
        }

        [TestMethod]
        public void Triangleto_Test_Right()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("triangle 20 30 40");
            Assert.AreEqual(result[0], "triangle", result[1], "20", result[2], "30", result[3], "40");

        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Triangle__Test_Wrong()
        {
            var v = new CodeVallidation();
            string[] result = v.valid("20 ");
            Assert.AreEqual(result[0], "triangle");
        }


    }
}

