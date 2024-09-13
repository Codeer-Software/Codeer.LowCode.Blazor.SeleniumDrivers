using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class TimeFieldDriver : ComponentBase
    {
        public TimeDriver Input => ByCssSelector("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public TimeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator TimeFieldDriver(ElementFinder finder) => finder.Find<TimeFieldDriver>();
    }
}
