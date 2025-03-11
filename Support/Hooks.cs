using Allure.Commons;
using Reqnroll;
using System.Diagnostics;

namespace NorthStandard.Support
{
    [Binding]
    public class Hooks
    {
        private static readonly AllureLifecycle allure = AllureLifecycle.Instance;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            allure.CleanupResultDirectory(); // Clean previous results
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            GenerateAllureReport();
        }

        //Generate Allure report
        private static void GenerateAllureReport()
        {
            try
            {
                string allureResultsPath = Path.Combine(Directory.GetCurrentDirectory(), "allure-results");
                string allureReportPath = Path.Combine(Directory.GetCurrentDirectory(), "allure-report");

                if (!Directory.Exists(allureResultsPath))
                {
                    Console.WriteLine("No Allure results found, skipping report generation.");
                    return;
                }

                Console.WriteLine("Generating Allure report...");

                var process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c allure generate {allureResultsPath} --clean -o {allureReportPath}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();

                Console.WriteLine("Allure report generated at: " + allureReportPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating Allure report: " + ex.Message);
            }
        }
    }
}
