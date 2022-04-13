using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit3NetCoreFramework.Base
{
    class ExtentManager
    {

        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;

        private ExtentManager()
        {

        }

        public static ExtentReports GetInstance()
        {

            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Reports\");
            string reportPath = Path.GetFullPath(sFile);

            htmlReporter = new ExtentHtmlReporter(reportPath);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("OS", "Windows");

            return extent;

        }

    }
}
