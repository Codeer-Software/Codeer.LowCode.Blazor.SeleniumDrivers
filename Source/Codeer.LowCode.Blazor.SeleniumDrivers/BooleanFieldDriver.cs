using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class BooleanFieldDriver : ComponentBase
    {
        public CheckBoxDriver Check => ByTagName("input").Wait();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public BooleanFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator BooleanFieldDriver(ElementFinder finder) => finder.Find<BooleanFieldDriver>();
    }
}
