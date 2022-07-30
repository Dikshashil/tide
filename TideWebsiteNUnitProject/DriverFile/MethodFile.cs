using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TideWebsiteNUnitProject.DriverFile
{
    public class MethodFile
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }
        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}
