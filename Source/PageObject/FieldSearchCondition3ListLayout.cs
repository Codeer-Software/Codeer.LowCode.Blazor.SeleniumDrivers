using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition3ListLayout : ListLayoutBase
    {

        public FieldSearchCondition3ListLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition3ListLayout(ElementFinder finder) => finder.Find<FieldSearchCondition3ListLayout>();
    }

}
