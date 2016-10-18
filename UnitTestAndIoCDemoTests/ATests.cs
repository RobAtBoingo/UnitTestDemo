using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestAndIoCDemo.Ioc;

namespace UnitTestAndIoCDemoTesting
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ATests
    {
        private A _a;

        private Mock<ITalkingThing> _talkingThingMock;

        private const string ValueToReturn = "Q";

        private Exception _exceptionToThrow;
        private Exception _exceptionCaught;

        private string _returnedValue;

        [TestInitialize]
        public void TestInitialize()
        {
            _returnedValue = null;
            _exceptionCaught = null;

            _exceptionToThrow = new Exception("Something went wrong.");

            _talkingThingMock = new Mock<ITalkingThing>();

            _talkingThingMock.Setup(m => m.Says()).Returns(ValueToReturn);

            _a = new A(_talkingThingMock.Object);
        }

        [TestMethod]
        public void SayIt_ReturnsQ_Works()
        {
            var returnedValue = _a.SayIt();

            _talkingThingMock.Verify(m => m.Says(), Times.Exactly(2));

            Assert.AreEqual(returnedValue, ValueToReturn);
        }

        [TestMethod]
        public void SayIt_ExceptionThrown_ExceptionCaught()
        {
            _talkingThingMock.Setup(m => m.Says()).Throws(_exceptionToThrow);

            try
            {
                _returnedValue = _a.SayIt();
            }
            catch (Exception exception)
            {
                _exceptionCaught = exception;
            }

            _talkingThingMock.Verify(m => m.Says(), Times.Once);

            Assert.AreEqual(_returnedValue, null);
            Assert.AreEqual(_exceptionCaught, _exceptionToThrow);
        }
    }
}
