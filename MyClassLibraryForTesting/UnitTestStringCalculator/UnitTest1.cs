using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace UnitTestStringCalculator
{
    [TestClass]
    public class UnitTest1
    {
        MyStringCalculator _tmp;

        [TestInitialize]
        public void Initialize()
        {
            _tmp = new MyStringCalculator();
        }


        [TestMethod]
        public void StringToLower_AAA_to_aaa()
        {
            //arange
            string myString = "AAA";
            string expectedResult = "aaa";

            //act
            string actualResult = _tmp.StringToLower(myString);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StringToUpper_aaa_to_AAA()
        {
            //arange
            string myString = "aaa";
            string expectedResult = "AAA";

            //act
            string actualResult = _tmp.StringToUpper(myString);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StringToInt_string_42_to_int_42()
        {
            //arange
            string myString = "42";
            int expectedResult = 42;

            //act
            int actualResult = _tmp.StringToInt(myString);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
