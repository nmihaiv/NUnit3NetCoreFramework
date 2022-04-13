using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit3NetCoreFramework.Base
{
    

    class Base
    {
        public ExtentReports reporter;
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            reporter = ExtentManager.GetInstance();
        }

    }
}
