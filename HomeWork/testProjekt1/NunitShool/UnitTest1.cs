 using NUnit.Framework;
 using System.Collections.Generic;

namespace NunitShoolNameSpase
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
       // Default Nunit with Assertion;
    }
}
