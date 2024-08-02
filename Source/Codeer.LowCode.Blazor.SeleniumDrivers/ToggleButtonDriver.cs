using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ToggleButtonDriver : ComponentBase
    {
        public bool IsChecked => ByTagName("input").Wait().Find().GetAttribute("btn-primary") == "true";
        
        public ToggleButtonDriver(IWebElement element) : base(element) { }
        public static implicit operator ToggleButtonDriver(ElementFinder finder) => finder.Find<ToggleButtonDriver>();
    }
}
