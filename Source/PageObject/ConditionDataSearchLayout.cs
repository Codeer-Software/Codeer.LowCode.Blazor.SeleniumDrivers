using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ConditionDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public ConditionDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ConditionDataSearchLayout(ElementFinder finder) => finder.Find<ConditionDataSearchLayout>();
    }

}
