using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FoxSportsSite
{
    /// <summary>
    /// Test cases for https://www.foxsports.com/ homepage.
    /// </summary>
    [TestClass]
    public class MainPageTest
    {
        private MainPage _mainPage;
        private IWebDriver _driver;

        [TestInitialize]
        public void SetupTest()
        {
            _driver = new ChromeDriver();
            _mainPage = new MainPage(_driver);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            _driver.Quit();
        }

        private TestContext testContextInstance;

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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [TestCategory("Core")]
        [Description("Navigate to Seahawks team page from home page NFL menu.")]
        public void NavigateToSeahawksSubSiteTest()
        {
            // ARRANGE - Open home page.
            SeattleSeahawksPage seahawkPage = _mainPage
                .Navigate()            
            // ACT - Open NFL menu and click Seattle Seahawks link.
                .ClickSeahawks();
            // ASSERT - Did "2017 SEATTLE SEAHAWKS" text return from DOM.        
            string actualText = _driver.FindElement(By.CssSelector("#wisfoxbox > h1 > span.wisbb_pageInfoPrimaryText")).Text;             
            Assert.AreEqual(actualText,"2017 SEATTLE SEAHAWKS:");
        }
    }
}
