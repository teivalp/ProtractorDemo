using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FoxSportsSite
{
    /// <summary>
    /// Stores all web elements properties for
    /// http://www.foxsports.com/
    /// </summary>
    partial class MainPage
    {
        // Header wrapper block

        // NFL link
        public IWebElement NflLink => driver.FindElement(By.XPath("//a[contains(@title='National Football League') and href='/nfl']"));
        // Seahawks link 
        public IWebElement SeahawksLink => driver.FindElement(By.XPath("//a[contains(@href='/nfl/seattle-seahawks-team')]"));
    }
}
