using OpenQA.Selenium;

namespace NorthStandard.Pages
{
   public class HomePage
    {
        private readonly IWebDriver driver;
        public string Url { get; private set; } = "https://www.selenium.dev/";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Navigate to the specified URL.
        /// </summary>
        public void NavigateToPage(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL cannot be null or empty", nameof(url));
            }
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (WebDriverException ex)
            {         
                throw new InvalidOperationException("Failed to navigate to the specified URL.", ex);
            }
        }

        /// <summary>
        /// Get the page title.
        /// </summary>
        public string GetPageTitle()
        {
            try
            {
                return driver.Title;
            }
            catch (WebDriverException ex)
            {
                throw new InvalidOperationException("Failed to retrieve the page title.", ex);
            }
        }
    }
}
