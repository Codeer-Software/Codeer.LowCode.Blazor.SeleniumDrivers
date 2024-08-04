using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateContactPersonSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public EstimateContactPersonSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateContactPersonSearchLayout(ElementFinder finder) => finder.Find<EstimateContactPersonSearchLayout>();
    }

}
