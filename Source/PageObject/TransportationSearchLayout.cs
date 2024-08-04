using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TransportationSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public TransportationSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator TransportationSearchLayout(ElementFinder finder) => finder.Find<TransportationSearchLayout>();
    }

}
