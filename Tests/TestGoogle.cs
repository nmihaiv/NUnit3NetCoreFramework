using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit3NetCoreFramework.Base;
using NUnit3NetCoreFramework.Models;
using NUnit3NetCoreFramework.PageObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit3NetCoreFramework.Tests
{
    [TestFixture]
    class TestGoogle : BaseTest
    {
        [Test]
        [TestCaseSource(typeof(GoogleModel))]
        public void TestSearchGoogle(dynamic testvar)
        {
            try
            {
                var googlePage = new GooglePage(driver);
                var resultPage = new GoogleResults(driver);

                actor.Log(Status.Info, "Starting the google test");
                actor.Log(Status.Info, "Opening google page");
                googlePage.OpenGooglePage();

                actor.Log(Status.Info, "Accepting all cookies like a pleb");
                googlePage.AcceptCookies();

                actor.Log(Status.Info, "Filling the search bar");
                googlePage.FillFields(testvar.Search.ToString());

                actor.Log(Status.Info, "Clicking Search Button");
                googlePage.PressSearchButton();

                resultPage.testsomething(testvar.ExpectedResult.ToString());


                actor.Log(Status.Pass, "Test passed successfully!");
            }
            catch (Exception e)
            {

                actor.Log(Status.Warning, "Test could not be completed successfully!");
                actor.Log(Status.Fail, "Fail message: </br><b>" + e.Message + "</b>");
            }
        }

    }
}
