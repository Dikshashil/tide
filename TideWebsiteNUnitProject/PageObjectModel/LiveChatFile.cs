using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsiteNUnitProject.DriverFile;

namespace TideWebsiteNUnitProject.PageObjectModel
{
    public class LiveChatFile
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
        }

        public static void ClickOnLiveChat()
        {
            Thread.Sleep(1000);
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(1000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[1]/div/div/div/div[2]/a[1]")).Click();
        }

        public static void ScrollToElement()
        {
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div")).Click();
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Result");
        }
    }
}
