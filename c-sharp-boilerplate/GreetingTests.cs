using NUnit.Framework;

namespace c_sharp_boilerplate
{
    [TestFixture]
    public class GreetingTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreSame(Greeting.sayHello(), "Hello World!");
        }
    }
}