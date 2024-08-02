using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SelectFieldDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public SelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator SelectFieldDriver(ElementFinder finder) => finder.Find<SelectFieldDriver>();
    }
}
