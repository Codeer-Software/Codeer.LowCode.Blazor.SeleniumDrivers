using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class IdFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public IdFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator IdFieldDriver(ElementFinder finder) => finder.Find<IdFieldDriver>();
    }
}
