using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition1ListLayout : ListLayoutBase
    {

        public FieldSearchCondition1ListLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition1ListLayout(ElementFinder finder) => finder.Find<FieldSearchCondition1ListLayout>();
    }

}
