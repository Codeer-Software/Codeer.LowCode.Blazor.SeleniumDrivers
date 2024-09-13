using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class DateTimeFieldDriver : ComponentBase
    {
        public DateTimeDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public DateTimeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator DateTimeFieldDriver(ElementFinder finder) => finder.Find<DateTimeFieldDriver>();
    }
}
