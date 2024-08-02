using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ProCodeFieldDriver : ComponentBase
    {
        public ProCodeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ProCodeFieldDriver(ElementFinder finder) => finder.Find<ProCodeFieldDriver>();
    }
}
