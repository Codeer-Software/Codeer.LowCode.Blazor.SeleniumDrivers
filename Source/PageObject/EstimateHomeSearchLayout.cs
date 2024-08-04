using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateHomeSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public EstimateHomeSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateHomeSearchLayout(ElementFinder finder) => finder.Find<EstimateHomeSearchLayout>();
    }

}
