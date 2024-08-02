using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class TextFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public TextAreaDriver TextArea => ByTagName("textarea").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public TextFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator TextFieldDriver(ElementFinder finder) => finder.Find<TextFieldDriver>();
    }
}
