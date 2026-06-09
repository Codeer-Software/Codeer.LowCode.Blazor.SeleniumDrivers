using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class CopyModuleButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Button => ByTagName("button").Wait();
        public CopyModuleButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator CopyModuleButtonFieldDriver(ElementFinder finder) => finder.Find<CopyModuleButtonFieldDriver>();
    }
}
