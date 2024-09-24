using OpenQA.Selenium;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public static class WebDriverExtensions
    {
        public static void WaitLoading(this IWebDriver driver)
        {
            Thread.Sleep(500);
            while (driver!.FindElements(By.ClassName("backdrop")).Count == 1)
            {
                Thread.Sleep(50);
            }
        }
    }
}
