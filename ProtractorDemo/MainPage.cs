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
        private readonly IWebDriver driver;
        private readonly string url = @"http://www.forxsports.com/";

        public MainPage(IWebDriver browser)
        {
            driver = browser;
        }

        public MainPage Navigate()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public MainPage ClickSeahawks()
        {
            NflLink.Click();
            return this;
        }

    }
}
