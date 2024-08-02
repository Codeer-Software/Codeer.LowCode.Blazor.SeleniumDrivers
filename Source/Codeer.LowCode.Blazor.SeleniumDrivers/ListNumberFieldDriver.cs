using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ListNumberFieldDriver : ComponentBase
    {
        public TextBoxDriver Label => ByTagName("label").Wait();
        public ListNumberFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ListNumberFieldDriver(ElementFinder finder) => finder.Find<ListNumberFieldDriver>();
    }
}
