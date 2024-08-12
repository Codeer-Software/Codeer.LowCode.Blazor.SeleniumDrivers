using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DriverTest1ChildrenSearchLayout : ComponentBase
    {

        public DriverTest1ChildrenSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator DriverTest1ChildrenSearchLayout(ElementFinder finder) => finder.Find<DriverTest1ChildrenSearchLayout>();
    }

}
