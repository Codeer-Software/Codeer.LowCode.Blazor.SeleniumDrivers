using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldTestSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public FieldTestSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldTestSearchLayout(ElementFinder finder) => finder.Find<FieldTestSearchLayout>();
    }

}
