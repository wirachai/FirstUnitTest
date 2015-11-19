using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstUnitTest.Test
{
    [TestFixture]
    class HelloWorldTest
    {
        [Test]
        public void Print_ShouldReturnHelloWorld_WhenCalled()
        {
            // arrange
            HelloWorld hello = new HelloWorld();

            // act
            string result = hello.Print();

            // assert
            Assert.AreEqual("Hello World", result);
        }
    }
}
