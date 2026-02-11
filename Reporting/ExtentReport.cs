using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCart.Reporting
{
    public class ExtentReport
    {
        private static ExtentReports extent;
        private static ExtentSparkReporter spark;

        public static ExtentReports GetReport()
        {
            if (extent == null)
            {
                string reportPath =
                    AppDomain.CurrentDomain.BaseDirectory +
                    @"\Reports\ExtentReport.html";

                spark = new ExtentSparkReporter(reportPath);
                spark.Config.DocumentTitle = "Automation Test Report";
                spark.Config.ReportName = "Selenium Test Execution";
                spark.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard;

                extent = new ExtentReports();
                extent.AttachReporter(spark);

               
            }
            return extent;
        }
    }
}
