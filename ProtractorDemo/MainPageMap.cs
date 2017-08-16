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
        #region Header wrapper block

        // NFL link
        public IWebElement NflLink => driver.FindElement(By.CssSelector("a[title='National Football League']"));
        // Seahawks link 
        public IWebElement SeahawksLink => driver.FindElement(By.CssSelector("a[href='/nfl/seattle-seahawks-team']"));

        #endregion
    }
}
