using NUnit.Framework;
using System.Collections.Generic;

namespace testProjekt1
{
    [TestFixture]
    public class MyTestClass
    {
        [Test]
        public void SimpleTestCheck()
        {
            string value1 = "Hallo";
            string value2 = "Hello";
            string result = value1 + value2;
        }
        [Test]
        public void SimpleTestPass()
        {
            string expectedResultat = "Hello";
            string actualResult = "Hello";
            Assert.AreEqual(expectedResultat, actualResult);
        }
        [Test]
        public void SimpleTestFail()
        {
            string expectedResultat = "Hello";
            string actualResult = "Hello World";
            Assert.AreEqual(expectedResultat, actualResult);
        }
       // [Test]
       // public void SimpleTestFailWithMassage()
        //{
        //    string expectedResultat = "Hello";
         //   string actualResult = "Hello World";
         //   Assert.AreEqual(expectedResultat, actualResult, "Actual result differens froms axpeted!");
        //}
    }
}
