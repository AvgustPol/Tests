using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibraryForTesting;
using Xunit;
using FakeItEasy;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ClassForTesting _tmp;

        [TestInitialize]
        public void Initialize()
        {
            _tmp = new ClassForTesting();
        }

        [TestMethod]
        public void Add_20_and_2_result_22()
        {
            //arange
            double a = 20;
            double b = 2;
            double expectedResult = 22;

            //act
            double actualResult = _tmp.Add(a, b);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Substract_20_and_2_result_18()
        {
            //arange
            double a = 20;
            double b = 2;
            double expectedResult = 18;

            //act
            double actualResult = _tmp.Substract(a, b);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Multiply_20_and_2_result_40()
        {
            //arange
            double a = 20;
            double b = 2;
            double expectedResult = 40;

            //act
            double actualResult = _tmp.Multiply(a, b);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Divide_20_and_0_result_Exception()
        {
            //arange
            double a = 20;
            double b = 0;

            //act

            //assert
            //Assert.Throws<Exception>(() => _sut.Divide(a, b));
            Assert.ThrowsException<Exception>(() => _tmp.Divide(a, b));
        }

        [TestMethod]
        public void Add_2_and_3_then_mulpiply_result_and_2_and_3_result_30()
        {
            //arange
            double a = 2;
            double b = 3;

            var fakeCalculator = A.Fake<ClassForTesting>();
            A.CallTo(() => fakeCalculator.Add(2, 3)).Returns(5);

            //act

            //assert

        }

    }
}
