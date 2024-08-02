using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Button => ByTagName("button").Wait();
        public ButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ButtonFieldDriver(ElementFinder finder) => finder.Find<ButtonFieldDriver>();
    }
}
