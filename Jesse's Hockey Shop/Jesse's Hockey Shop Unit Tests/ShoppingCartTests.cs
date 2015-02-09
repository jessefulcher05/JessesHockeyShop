using System;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JessesHockeyShop;
using JessesHockeyShop.Logic;
using JessesHockeyShop.Models;

namespace Jesse_s_Hockey_Shop_Unit_Tests
{
    [TestClass]
    public class ShoppingCartTotalTests
    {
        CartItem myItem = new CartItem();

        [TestMethod]
        public void ShoppingCartTotalWithOneItem()
        {
            myItem.CartId = "1";
            myItem.DateCreated = new DateTime(2014, 1, 1);
            myItem.ItemId = "1";
            myItem.Product = new Product
                {
                    ProductID = 1,
                    ProductName = "Test",
                    Description = "Test",
                    UnitPrice = 219.99,
                    CategoryID = 1
                };
            myItem.ProductId = 1;
            myItem.Quantity = 1;

            ShoppingCartObject scObject = new ShoppingCartObject();

            scObject.sc_CartItemList.Add(myItem);

            double total = scObject.getTotal();

            //Assert
            Assert.AreEqual(219.99, total);

        }

        [TestMethod]
        public void ShoppingCartTotalWithTwoSameItem()
        {
            myItem.CartId = "1";
            myItem.DateCreated = new DateTime(2014, 1, 1);
            myItem.ItemId = "1";
            myItem.Product = new Product
            {
                ProductID = 1,
                ProductName = "Test",
                Description = "Test",
                UnitPrice = 100.00,
                CategoryID = 1
            };
            myItem.ProductId = 1;
            myItem.Quantity = 2; //make quantity of one item to multiple to test that totals are adding correclty

            ShoppingCartObject scObject = new ShoppingCartObject();

            scObject.sc_CartItemList.Add(myItem);

            double total = scObject.getTotal();

            //Assert
            Assert.AreEqual(200.00, total);
        }

        [TestMethod]
        public void ShoppingCartTotalWithTwoDifferentItems()
        {
            //First Item
            myItem.CartId = "1";
            myItem.DateCreated = new DateTime(2014, 1, 1);
            myItem.ItemId = "1";
            myItem.Product = new Product
            {
                ProductID = 1,
                ProductName = "Test",
                Description = "Test",
                ImagePath = "test.jpg",
                UnitPrice = 100.00,
                CategoryID = 1
            };
            myItem.ProductId = 1;
            myItem.Quantity = 1;

            //Second Item
            CartItem myItem2 = new CartItem(); //create a second item
            myItem2.CartId = "1";
            myItem2.DateCreated = new DateTime(2014, 1, 1);
            myItem2.ItemId = "2";
            myItem2.Product = new Product
            {
                ProductID = 2,
                ProductName = "test",
                Description = "test",
                ImagePath = "nexusElevate.jpg",
                UnitPrice = 100.00,
                CategoryID = 1
            };
            myItem2.ProductId = 2;
            myItem2.Quantity = 1;

            //Create Shopping Cart
            ShoppingCartObject scObject = new ShoppingCartObject();

            scObject.sc_CartItemList.Add(myItem); //add first item to shopping cart
            scObject.sc_CartItemList.Add(myItem2); //add second item to the shopping cart

            double total = scObject.getTotal(); //set total to the method we have to get actual total when these are here

            //Assert if hard coded value and method to retrieve are equal.
            Assert.AreEqual(200.00, total);
        }

        [TestMethod]
        public void ShoppingCartTotalWithDifferentItemsAndQuantities()
        {
            //First Item
            myItem.CartId = "1";
            myItem.DateCreated = new DateTime(2014, 1, 1);
            myItem.ItemId = "1";
            myItem.Product = new Product
                {
                    ProductID = 1,
                    ProductName = "Test",
                    Description = "Test",
                    UnitPrice = 100.00,
                    CategoryID = 1
                };
            myItem.ProductId = 1;
            myItem.Quantity = 1;

            //Second Item
            CartItem myItem2 = new CartItem(); //create a second item
            myItem2.CartId = "1";
            myItem2.DateCreated = new DateTime(2014, 1, 1);
            myItem2.ItemId = "2";
            myItem2.Product = new Product
            {
                ProductID = 2,
                ProductName = "test",
                Description = "test",
                ImagePath = "nexusElevate.jpg",
                UnitPrice = 100.00,
                CategoryID = 1
            };
            myItem2.ProductId = 2;
            myItem2.Quantity = 2;

            ShoppingCartObject scObject = new ShoppingCartObject();

            scObject.sc_CartItemList.Add(myItem);
            scObject.sc_CartItemList.Add(myItem2); //add second item to the shopping cart

            double total = scObject.getTotal();

            //Assert
            Assert.AreEqual(300, total);
        }
    }
}
