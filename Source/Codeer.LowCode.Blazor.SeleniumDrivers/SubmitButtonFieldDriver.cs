using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SubmitButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Submit => ByTagName("button").Wait();
        public SubmitButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator SubmitButtonFieldDriver(ElementFinder finder) =>
            finder.Find<SubmitButtonFieldDriver>();
    }
}
