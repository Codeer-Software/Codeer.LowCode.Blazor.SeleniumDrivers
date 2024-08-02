using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class AnchorTagFieldDriver : ComponentBase
    {
        public AnchorDriver Anchor => ByTagName("a").Wait();
        public AnchorTagFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator AnchorTagFieldDriver(ElementFinder finder) =>
            finder.Find<AnchorTagFieldDriver>();
    }
}
