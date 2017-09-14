using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace FoxSportsSite
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver Driver, By By, int TimeoutInSeconds)
        {
            if (TimeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(TimeoutInSeconds));                
                return wait.Until(ExpectedConditions.ElementIsVisible(By));
            }
            return Driver.FindElement(By);
        }
        /// <summary>
        /// Find and wait for element to appear.
        /// Catch NoSuchElementException if thrown
        /// </summary>
        /// <param name="Driver">Browser interface set by test</param>
        /// <param name="By">Object set by test to locate element</param>
        /// <returns>True/False</returns>
        public static bool IsElementPresent(this IWebDriver Driver, By By)
        {
            try
            {
                FindElement(Driver, By, 5);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
