using NUnit3NetCoreFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit3NetCoreFramework.PageObject
{
    class GooglePage
    {

        private IWebDriver Driver;
        public GooglePage(IWebDriver driver) => Driver = driver;

        public IWebElement SearchBar => Driver.FindElement(By.Name("q"),3);
        public IWebElement SearchButton => Driver.FindElement(By.Name("btnK"),3);
        public IWebElement CookieButton => Driver.FindElement(By.Id("L2AGLb"));



        public void AcceptCookies()
        {
            CookieButton.Click();
        }

        public void FillFields(string searchItem)
        {
            SearchBar.SendKeys(searchItem);
        }

        public void PressSearchButton()
        {
            
            SearchButton.Click();
        }

        public void OpenGooglePage()
        {
            Driver.Url = "https://www.google.com/";
        }


    }
}
