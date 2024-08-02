using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class PagerDriver : ComponentBase
    {
        public AnchorDriver First => ByCssSelector("li.page-item:nth-child(1) a").Wait();
        public AnchorDriver Previous => ByCssSelector("li.page-item:nth-child(2) a").Wait();
        public AnchorDriver Next => ByCssSelector("li.page-item:nth-last-child(2) a").Wait();
        public AnchorDriver Last => ByCssSelector("li.page-item:last-child a").Wait();
        public AnchorDriver Pages => ByCssSelector("li.page-item:not(.disabled):nth-child(n+3):nth-last-child(n+3) a").Wait();
        public PagerDriver(IWebElement element) : base(element) { }
        public static implicit operator PagerDriver(ElementFinder finder) => finder.Find<PagerDriver>();
    }
}
