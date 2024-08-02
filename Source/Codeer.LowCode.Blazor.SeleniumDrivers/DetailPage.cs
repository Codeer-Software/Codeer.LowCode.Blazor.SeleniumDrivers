using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class DetailPage<TDetailLayout> : PageBase where TDetailLayout : ComponentBase
    {
        public TDetailLayout Detail => ByTagName("main").Wait().Find<TDetailLayout>();
        public DetailPage(IWebDriver driver) : base(driver) { }
    }
}
