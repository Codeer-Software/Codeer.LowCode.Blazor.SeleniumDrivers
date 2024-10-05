using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class IsRequiredSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public IsRequiredSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredSearchLayout(ElementFinder finder) => finder.Find<IsRequiredSearchLayout>();
    }

}
