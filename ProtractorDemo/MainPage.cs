using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FoxSportsSite
{    
    /// <summary>
    /// Contains the constructor(s) and the action methods for
    /// http://www.foxsports.com/
    /// </summary>
    partial class MainPage
    {
        // Instantiate a classic Selenium's Webdriver
        private readonly IWebDriver _driver;
        private readonly string url = @"http://www.forxsports.com/";

        public MainPage(IWebDriver Driver)
        {
            _driver = Driver;
        }

        public MainPage Navigate()
        {
            _driver.Navigate().GoToUrl(url);
            return this;
        }

        public MainPage ClickSeahawks()
        {
            NflLink.Hover(_driver);
            SeahawksLink.Click();
            return this;
        }
    }
}
