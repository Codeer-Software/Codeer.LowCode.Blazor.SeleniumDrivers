using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition2SearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public FieldSearchCondition2SearchLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition2SearchLayout(ElementFinder finder) => finder.Find<FieldSearchCondition2SearchLayout>();
    }

}
