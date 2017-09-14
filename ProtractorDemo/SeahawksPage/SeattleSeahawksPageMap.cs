using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FoxSportsSite.SeahawksPage
{
    /// <summary>
    /// Stores all web elements properties for
    /// http://www.foxsports.com/nfl/seattle-seahawks-team
    /// </summary>
    public partial class SeattleSeahawksPage
    {
        // Page asserter: <link rel="canonical" href="http://www.foxsports.com/nfl/seattle-seahawks-team">
        public IWebElement CanonicalLink
        {
            get
            {
                return this._driver.FindElement(By.CssSelector("link[rel='canonical'][href='http://www.foxsports.com/nfl/seattle-seahawks-team']"));
            }
        }
    }
}
