using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class MarkupStringFieldDriver : ComponentBase
    {
        public MarkupStringFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MarkupStringFieldDriver(ElementFinder finder) => finder.Find<MarkupStringFieldDriver>();
    }
}
