using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SearchModeDriver : ComponentBase
    {
        public IWebElement Toggle => ByCssSelector("[data-system='search-mode-toggle']").Wait().Find();
        public string CurrentMode => Toggle.GetAttribute("data-system-mode") ?? "";

        public void SelectMode(string mode)
        {
            Toggle.Click();
            Thread.Sleep(100);
            ByCssSelector($"[data-system='search-mode-item'][data-system-mode='{mode}']").Wait().Find().Click();
        }

        public SearchModeDriver(IWebElement element) : base(element) { }
        public static implicit operator SearchModeDriver(ElementFinder finder) => finder.Find<SearchModeDriver>();
    }
}
