using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class LabelFieldDriver : ComponentBase
    {
        public IWebElement Label => ByTagName("label").Wait().Find();
        public LabelFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator LabelFieldDriver(ElementFinder finder) => finder.Find<LabelFieldDriver>();
    }
}
