using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
