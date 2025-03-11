using NorthStandard.Utilities;
using OpenQA.Selenium;


namespace NorthStandard.Tests
{
    public class TestBase : IDisposable
    {

        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverSetup.InitializeWebDriver();
           
        }

        [TearDown]
        public void Cleanup()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (driver != null)
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception during driver quit: {ex.Message}");
                }
                finally
                {
                    driver.Dispose();
                }
            }
        }
    }
}
