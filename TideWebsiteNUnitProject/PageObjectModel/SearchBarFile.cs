using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsiteNUnitProject.PageObjectModel;
using TideWebsiteNUnitProject.DriverFile;
using OpenQA.Selenium;

namespace TideWebsiteNUnitProject.PageObjectModel
{
    public class SearchBarFile
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
        }

        public static void ClickOnSearchBar()
        {
            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            Thread.Sleep(3000);
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[2]/div/div/div/form/div/input")).Click();
        }

        public static void PutValueInSearchBar()
        {
            IWebElement seachBarElement = MethodFile.driver.FindElement(By.XPath("//input[@type='search']"));
            seachBarElement.SendKeys("Powder Detergent");
            seachBarElement.SendKeys(Keys.Enter);
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Result");
        }
    }
}
