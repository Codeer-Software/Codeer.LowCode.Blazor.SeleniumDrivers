using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ViewEditToggleButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Button => ByTagName("button").Wait();
        public ViewEditToggleButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ViewEditToggleButtonFieldDriver(ElementFinder finder) => finder.Find<ViewEditToggleButtonFieldDriver>();
    }
}
