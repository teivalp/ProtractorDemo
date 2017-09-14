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
    public partial class MainPage
    {
        // Instantiate a classic Selenium's Webdriver
        private readonly IWebDriver _driver;
        private readonly string _url = @"http://www.foxsports.com/";

        public MainPage(IWebDriver browser)
        {
            _driver = browser;
        }

        public MainPage Navigate()
        {
            _driver.Navigate().GoToUrl(_url);
            return this;
        }

        public SeattleSeahawksPage ClickSeahawks()
        {
            NflLink.Hover(_driver);
            SeahawksLink.Click();
            return new SeattleSeahawksPage();
        }
    }
}
