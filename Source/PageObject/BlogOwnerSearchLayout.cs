using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogOwnerSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public BlogOwnerSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogOwnerSearchLayout(ElementFinder finder) => finder.Find<BlogOwnerSearchLayout>();
    }

}
