using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsiteNUnitProject.DriverFile;
using TideWebsiteNUnitProject.PageObjectModel;

namespace TideWebsiteNUnitProject.PageObjectModel
{
    public class LanguageChange
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
        }

        public static void ClickButton()
        {
            Thread.Sleep(1000);
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(1000);
            MethodFile.driver.FindElement(By.XPath("//button[contains(text(), 'US - English')]")).Click();
        }

        public static void ChooseLanguage()
        {
            MethodFile.driver.FindElement(By.XPath("//a[contains(text(), 'US - Spanish')]")).Click();
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("LanguageChangeScreenShot");
        }
    }
}
