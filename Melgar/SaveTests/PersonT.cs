using Microsoft.VisualStudio.TestTools.UnitTesting;
using melgar;
using Person;

namespace SaveTests
{
    [TestClass]
    public class PersonT
    {
        [TestMethod]
        public void TestSaveMoney ()
        {
            //Arrange
            double beginningsave = 10;
            double seva = 30;
            double expected = 40;
            Person money = new Person("river", beginningsave);
            //Act
            money.save(Save);
            //Assert
            Assert.AreEqual(expected, 0.001);
        }
        [TestMethod]
        public void Nametest()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
