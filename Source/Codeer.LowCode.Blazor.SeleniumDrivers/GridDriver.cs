using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class GridDriver : ComponentBase
    {
        public ButtonDriver Expander => ByCssSelector("[data-system='expander']").Wait();
        public GridDriver(IWebElement element) : base(element) { }
        public static implicit operator GridDriver(ElementFinder finder) => finder.Find<GridDriver>();
    }
}
