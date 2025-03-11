using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using WebDriverManager.Helpers;


namespace NorthStandard.Utilities
{
    public class WebDriverSetup
    {
        public static IWebDriver InitializeWebDriver()
        {
            // Automatically downloads compatible ChromeDriver
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            return new ChromeDriver();
        }
    }
}
