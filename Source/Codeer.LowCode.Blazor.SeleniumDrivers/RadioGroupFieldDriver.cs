using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class RadioGroupFieldDriver : ComponentBase
    {
        public IWebElement Value => ByTagName("span").Wait().Find();
        public RadioGroupFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator RadioGroupFieldDriver(ElementFinder finder) =>
            finder.Find<RadioGroupFieldDriver>();
    }
}
