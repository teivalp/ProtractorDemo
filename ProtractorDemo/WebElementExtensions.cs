using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace FoxSportsSite
{
    public static class WebElementExtensions
    {
        /// <summary>
        /// Create a right click action for the designated IWebElement
        /// </summary>
        /// <param name="Element">IWebElement</param>
        /// <param name="Driver">Interface controlling browser</param>
        public static void ContextMenu(this IWebElement Element, IWebDriver Driver)
        {
            // Create Actions object            
            Actions builder = new Actions(Driver);
            // Use ContextClick method to open context menu of IWebElement
            builder.ContextClick(Element).Build().Perform();
        }
        /// <summary>
        /// Hover mouse icon without performing a click
        /// </summary>
        /// <param name="Element"></param>
        /// <param name="Driver">Interface controlling browser</param>
        public static void Hover(this IWebElement Element, IWebDriver Driver)
        {            
            Actions action = new Actions(Driver);
            action.MoveToElement(Element).Perform();
        }
    }
}
