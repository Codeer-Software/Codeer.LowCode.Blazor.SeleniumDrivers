using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition2ListLayout : ListLayoutBase
    {

        public FieldSearchCondition2ListLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition2ListLayout(ElementFinder finder) => finder.Find<FieldSearchCondition2ListLayout>();
    }

}
