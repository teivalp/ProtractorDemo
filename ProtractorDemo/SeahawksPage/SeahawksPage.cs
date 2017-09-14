using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FoxSportsSite.SeahawksPage
{
    /// <summary>
    /// Contains the constructor(s) and the action methods for
    /// http://www.foxsports.com/nfl/seattle-seahawks-team
    /// </summary>
    public partial class SeattleSeahawksPage
    {
        // Instantiate a classic Selenium's Webdriver
        private readonly IWebDriver _driver;
        private readonly string _url = @"http://www.foxsports.com/nfl/seattle-seahawks-team";

        public SeattleSeahawksPage(IWebDriver browser)
        {
            _driver = browser;
        }

        public SeattleSeahawksPage Navigate()
        {
            _driver.Navigate().GoToUrl(_url);
            return this;
        }
    } 
}
