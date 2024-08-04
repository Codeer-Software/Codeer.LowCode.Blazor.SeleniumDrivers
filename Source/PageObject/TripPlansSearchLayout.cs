using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TripPlansSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public TripPlansSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator TripPlansSearchLayout(ElementFinder finder) => finder.Find<TripPlansSearchLayout>();
    }

}
