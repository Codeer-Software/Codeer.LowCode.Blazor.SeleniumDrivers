using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class DateFieldDriver : ComponentBase
    {
        public DateDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public DateFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator DateFieldDriver(ElementFinder finder) => finder.Find<DateFieldDriver>();
    }
}
