using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class NumberFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public NumberFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator NumberFieldDriver(ElementFinder finder) => finder.Find<NumberFieldDriver>();
    }
}
