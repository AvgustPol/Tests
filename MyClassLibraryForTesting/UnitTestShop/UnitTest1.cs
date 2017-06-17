﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using MyShop;
using System.Collections.Generic;

namespace UnitTestShop
{
    [TestClass]
    public class UnitTest1
    {
        Shop _testShop; 

        public UnitTest1()
        {
            // this is mock 
            var fakeUselessClass = A.Fake<IUselessClass>();
            A.CallTo(() => fakeUselessClass.ReturnTheSameDecimal(525)).Returns(525);
            A.CallTo(() => fakeUselessClass.ReturnTheSameInt(30)).Returns(30);
            _testShop = new Shop(fakeUselessClass);
        }

        [TestMethod]
        public void CalculatePrices_adds_prices_of_every_product_in_list()
        {
            //Arrange
            IList<Product> listOfItems = new List<Product>()
            {
                new Product(){Price = 150},
                new Product(){Price = 175},
                new Product(){Price = 200}
                //new Product(150, 10),
                //new Product(175, 10),
                //new Product(200, 10)
            };
            decimal expectedResult = 525;
            //Act
            decimal actualResult = _testShop.CalculatePrices(listOfItems);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void CalculateAmount_adds_amount_of_every_product_in_list()
        {
            //Arrange
            IList<Product> listOfItems = new List<Product>()
            {
                new Product(150, 10),
                new Product(175, 10),
                new Product(200, 10)
            };
            decimal expectedResult = 30;
            //Act
            decimal actualResult = _testShop.CalculateAmount(listOfItems);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
