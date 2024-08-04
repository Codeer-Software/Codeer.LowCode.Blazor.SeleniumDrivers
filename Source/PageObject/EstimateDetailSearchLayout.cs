using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateDetailSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public EstimateDetailSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateDetailSearchLayout(ElementFinder finder) => finder.Find<EstimateDetailSearchLayout>();
    }

}
