using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoxSportsSite
{
    /// <summary>
    /// Holds all assertions for 
    /// http://www.foxsports.com/
    /// </summary>

public partial class MainPage
    {
        public MainPage ResultsCount(string expectedCount)
        {
            Assert.AreEqual(CanonicalLink, expectedCount);
            return this;
        }
    }
}
