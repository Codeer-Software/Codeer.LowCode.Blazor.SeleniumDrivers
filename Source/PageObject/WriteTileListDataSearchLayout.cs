using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class WriteTileListDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public WriteTileListDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteTileListDataSearchLayout(ElementFinder finder) => finder.Find<WriteTileListDataSearchLayout>();
    }

}
