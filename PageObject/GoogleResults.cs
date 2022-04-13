using NUnit.Framework;
using NUnit3NetCoreFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit3NetCoreFramework.PageObject
{
    class GoogleResults
    {
        private IWebDriver Driver;
        public GoogleResults(IWebDriver driver) => Driver = driver;

        public IWebElement SearchResult => Driver.FindElement(By.XPath("//*[contains(text(),'Home - One Search Ltd')]"), 5);


        public void testsomething(string expectedResult)
        {
            Assert.AreEqual("Home - One Search Ltd", SearchResult.Text.ToString());
        }

    }
}
