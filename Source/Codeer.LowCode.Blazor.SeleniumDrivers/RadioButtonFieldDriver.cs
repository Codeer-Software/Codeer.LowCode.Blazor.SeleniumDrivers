using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class RadioButtonFieldDriver : ComponentBase
    {
        public CheckBoxDriver Input => ByTagName("input").Wait();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public RadioButtonFieldDriver(IWebElement element) : base(element) { }

        public static implicit operator RadioButtonFieldDriver(ElementFinder finder) =>
            finder.Find<RadioButtonFieldDriver>();
    }
}
