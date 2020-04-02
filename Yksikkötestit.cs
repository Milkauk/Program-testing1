using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studiolaskin;

namespace Laskintestit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSimple()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int luku1 = 4;
            int luku2 = 5;
            int oletus = 9;

            //Act
            int tulos = calculator.Add(luku1, luku2);

            //Assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void DeductSimple()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int luku1 = 10;
            int luku2 = 7;
            int oletus = 3;

            //Act
            int tulos = calculator.Deduct(luku1, luku2);

            //Assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void TimesSimple()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int luku1 = 4;
            int luku2 = 5;
            int oletus = 20;

            //Act
            int tulos = calculator.Times(luku1, luku2);

            //Assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void DivideSimple()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int luku1 = 10;
            int luku2 = 5;
            int oletus = 2;

            //Act
            int tulos = calculator.Divide(luku1, luku2);

            //Assert
            Assert.AreEqual(oletus, tulos);
        }
    }
}
