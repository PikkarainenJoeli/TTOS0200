using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoLaskin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLaskin.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {

        [TestMethod()]
        public void AddTest()
        {
            //Testataan MyCalculator-luokan  Add- metodia AAA- mallia

            //Arrange
            int i = 10;
            int j = 12;
            int tulos = 22;
            MyCalculator laskin = new MyCalculator();

            //Act
            int summa = laskin.Add(i, j);

            //Assert
            Assert.AreEqual(tulos, summa);


            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //Testataan MyCalculator-luokan  multiply- metodia AAA- mallia

            //Arrange
            int i = 10;
            int j = 12;
            int tulos = 120;
            MyCalculator laskin = new MyCalculator();

            //Act
            int tulo = laskin.Multiply(i, j);

            //Assert
            Assert.AreEqual(tulos, tulo);

            //Assert.Fail();
        }


        [TestMethod()]
        public void DivideTest()
        {
            //Testataan MyCalculator-luokan  multiply- metodia AAA- mallia

            //Arrange
            int i = 24;
            int j = 0;
            int odotettu = 1;
            MyCalculator laskin = new MyCalculator();

            //Act
            try
            {
                int jako = laskin.Divide(i, j);
                Assert.Fail();
                
            }

            catch(DivideByZeroException)
            {
                //Assert.ThrowsException<DivideByZeroException>(laskin.Divide(i, j));
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            //Assert
            DivideByZeroException dbze = new DivideByZeroException();
            //Assert.AreEqual(odotettu, jako);


        }
    }
}