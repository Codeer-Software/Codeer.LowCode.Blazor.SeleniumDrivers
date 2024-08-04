using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DestinationsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver Label目的地 => ByCssSelector("div[data-name='Label目的地']").Wait();
        public TextFieldSearchDriver Name目的地 => ByCssSelector("div[data-name='Name目的地']").Wait();

        public DestinationsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator DestinationsSearchLayout(ElementFinder finder) => finder.Find<DestinationsSearchLayout>();
    }

}
