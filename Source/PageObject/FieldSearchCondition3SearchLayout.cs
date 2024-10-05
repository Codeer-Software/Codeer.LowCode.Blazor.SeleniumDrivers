using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition3SearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public FieldSearchCondition3SearchLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition3SearchLayout(ElementFinder finder) => finder.Find<FieldSearchCondition3SearchLayout>();
    }

}
