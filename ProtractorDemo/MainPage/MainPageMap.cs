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
    public partial class MainPage
    {
        #region Header wrapper block

        // NFL link        
        public IWebElement NflLink
        {           
            get
            {
                return this._driver.FindElement(By.CssSelector("a[title='National Football League']"));
            }
        }
        // Seahawks link 
        public IWebElement SeahawksLink
        {
            get
            {
                return this._driver.FindElement(By.CssSelector("a[href='/nfl/seattle-seahawks-team']"));
            }
        }
        // Page asserter: <link rel="canonical" href="http://www.foxsports.com">
        public IWebElement CanonicalLink
        {
            get
            {
                return this._driver.FindElement(By.CssSelector("link[rel='canonical'][href='http://www.foxsports.com']"));
            }
        }
        
        #endregion
    }
}
