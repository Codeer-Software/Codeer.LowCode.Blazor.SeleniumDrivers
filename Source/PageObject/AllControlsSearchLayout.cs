using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class AllControlsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public AllControlsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator AllControlsSearchLayout(ElementFinder finder) => finder.Find<AllControlsSearchLayout>();
    }

}
