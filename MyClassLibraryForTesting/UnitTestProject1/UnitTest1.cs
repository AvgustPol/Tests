using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibraryForTesting;

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
        public void Add_20_2_result_22()
        {
            //arange
            int a = 20;
            int b = 2;
            int expectedResult = 22;

            //act
            int actualResult = _tmp.Add(a, b);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
