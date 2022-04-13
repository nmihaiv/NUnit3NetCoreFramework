using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit3NetCoreFramework.Base
{
    class BaseTest : Base
    {

        public ExtentTest actor;

        [SetUp]
        public void OpenTest()
        {
            actor = reporter.CreateTest(TestContext.CurrentContext.Test.Name.ToString());
            AssignCategories();

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
            reporter.Flush();
        }

        private void AssignCategories()
        {
            var categoriesList = TestContext.CurrentContext.Test.Properties["Category"];

            foreach (var category in categoriesList)
            {
                actor.AssignCategory(category.ToString());
            }
        }

    }
}
