using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsiteNUnitProject.DriverFile;

namespace TideWebsiteNUnitProject.PageObjectModel
{
    public class OurCommitmentFile
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
        }
        public static void ClickButton()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div/div/div/div[2]/a")).Click();
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Our Commitments Screenshot");
        }
    }
}
