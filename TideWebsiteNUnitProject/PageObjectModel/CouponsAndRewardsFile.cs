using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsiteNUnitProject.DriverFile;

namespace TideWebsiteNUnitProject.PageObjectModel
{
    public class CouponsAndRewardsFile
    {
        public static void NavigateURL()
        {
            MethodFile.driver.Manage().Window.Maximize();
            MethodFile.driver.Navigate().GoToUrl(ExcelFile.excelRead(1, 1));
        }

        public static void ClickCouponsAndRewards()
        {
            MethodFile.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div/div/div/div[5]/a")).Click();
        }

        public static void TakeScreenShot()
        {
            ScreenShotFile.ScreenShot("Coupons and Rewards ScreenShot");
        }

    }
}
