using Allure.NUnit.Attributes;
using NorthStandard.Pages;
using NorthStandard.Utilities;
using OpenQA.Selenium;
using Reqnroll;

namespace NorthStandard.StepDefinitions
{
    [Binding]
    [AllureSuite("Page Title Tests")]
    public class VerifyPageTitleStepDefinitions
    {
        private IWebDriver? driver;
        private HomePage? homePage;

        // Initialize the ChromeDriver and maximize the browser window
        [Given("I have set the chrome driver")]
        [AllureStep("Initialize ChromeDriver")]
        public void GivenIHaveSetTheChromeDriver()
        {
            try
            {
                driver = WebDriverSetup.InitializeWebDriver();
                driver.Manage().Window.Maximize();
                homePage = new HomePage(driver);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing ChromeDriver: {ex.Message}");
                throw;
            }

        }

        // Navigate to the specified URL
        [When("I navigate to the page url {string}")]
        [AllureStep("Navigate to {0}")]
        public void WhenINavigateToThePageUrl(string url)
        {
            try
            {
                if (driver == null)
                {
                    throw new InvalidOperationException("WebDriver is not initialized. Please ensure the Chrome driver is set.");
                }

                homePage!.NavigateToPage(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error navigating to URL {url}: {ex.Message}");
                throw;
            }

        }

        // Validate that the page title matches the expected title

        [Then("the page title should be {string}")]
        [AllureStep("Validate page title is {0}")]
        public void ThenThePageTitleShouldBe(string expectedTitle)
        {
            try
            {
                Assert.That(homePage!.GetPageTitle(), Is.EqualTo(expectedTitle));
                driver!.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error validating page title: {ex.Message}");
                throw;
            }
        }
    }
}
