using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition1SearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public FieldSearchCondition1SearchLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition1SearchLayout(ElementFinder finder) => finder.Find<FieldSearchCondition1SearchLayout>();
    }

}
