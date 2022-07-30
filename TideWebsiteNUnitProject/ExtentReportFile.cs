using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TideWebsiteNUnitProject
{
    public class ExtentReportFile
    {
        public static ExtentReports extent;
       // public static ExtentTest test;

        public static void generateReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\mindc1may168\Desktop\Comprehensive\TideWebsiteNUnitProject\");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);    
        }

        public static void flushReport()
        {
            extent.Flush();
        }
    }
}
