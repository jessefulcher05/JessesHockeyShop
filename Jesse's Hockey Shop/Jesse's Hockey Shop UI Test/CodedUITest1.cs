using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Jesse_s_Hockey_Shop_UI_Test
{
    /// <summary>
    /// These are the coded UI tests for Jesse's Hockey Shop. Each of them will first open up the site and then perform diffrent actions.
    /// </summary>
    [CodedUITest]
    public class JessesHockeyShopCodedUITest
    {
        //constructor for CodedUITest
        public JessesHockeyShopCodedUITest()
        {

        }

        [TestMethod]
        //This method fist navigates to the home page, adds one item and adjust the quantity of them then clicks update. It checks that order total is showing correct amount.
        public void testAmountTotalLableUpdate()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.NavigateToJessesHockeyShopInIE(); //this method naviagates to jesseshockeyshop.azurewebsites.net so that we don't have to replicate this step each time
            this.UIMap.NavigateToCartAndUpdateQuantity(); //navigates to shopping cart and updates quantity to 5
            this.UIMap.CheckOrderTotalWhenUpdating(); //after updating checks that Order Total is correct amount
        }

        [TestMethod]
        //same as above method but it is testing the text boxes that have the amount. tests that they are updating correctly.
        public void testQuantityTextBoxUpdate()
        {
            this.UIMap.NavigateToJessesHockeyShopInIE(); //this method naviagates to jesseshockeyshop.azurewebsites.net so that we don't have to replicate this step each time
            this.UIMap.NavigateToCartAndUpdateQuantity(); //navigates to shopping cart and updates quantity to 5
            this.UIMap.AssertThatQuantityEnteredIsCorrect(); //checks to see that item that was entered is same that is displaying now.
        }

        [TestMethod]
        public void testRemoveItemCheckBox()
        {
            this.UIMap.NavigateToJessesHockeyShopInIE(); //this method naviagates to jesseshockeyshop.azurewebsites.net so that we don't have to replicate this step each time
            this.UIMap.AddMultipleItemsThenRemoveOneItem(); //add multiple items then remove one item with check box, then click update.
            this.UIMap.CheckAmountOfRowsAfterRemoval(); //checks that correct amount of rows in shopping cart are showing
        }

        [TestMethod]
        public void testPasswordDontMatchValidation()
        {
            this.UIMap.NavigateToJessesHockeyShopInIE(); //this method naviagates to jesseshockeyshop.azurewebsites.net so that we don't have to replicate this step each time
            this.UIMap.RegisterWithMismatchPassword(); //attempt to register with passwords that do not match
            this.UIMap.CheckIfPasswordDoNotMatchMessageIsDisplayed(); //check to see if correct message is shown when correct passwords are not entered

        }

        [TestMethod]
        public void checkLoginFail()
        {
            this.UIMap.NavigateToJessesHockeyShopInIE(); //this method naviagates to jesseshockeyshop.azurewebsites.net so that we don't have to replicate this step each time
            this.UIMap.EnterWrongAdminPassword(); //clicks login button then types in wrong admin password to check we are getting error message
            this.UIMap.CheckErrorMessage(); //checks that we are getting the correct error message when password is wrong
        }

        [TestMethod]
        public void checkLoginSuccessfull()
        {
            this.UIMap.NavigateToJessesHockeyShopInIE(); //this method naviagates to jesseshockeyshop.azurewebsites.net so that we don't have to replicate this step each time
            this.UIMap.EnterCorrectAdminPassword(); //enter correct admin credentials
            this.UIMap.CheckCorrectAdminPage(); //assess to see if we see the correct admin page.
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
