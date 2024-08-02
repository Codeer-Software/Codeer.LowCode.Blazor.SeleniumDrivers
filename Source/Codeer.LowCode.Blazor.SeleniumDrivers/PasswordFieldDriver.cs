using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class PasswordFieldDriver : ComponentBase
    {
        public TextBoxDriver Password => ByTagName("input:not(.password-confirm)").Wait();
        public TextBoxDriver PasswordConfirm => ByCssSelector("input.password-confirm").Wait();
        public PasswordFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator PasswordFieldDriver(ElementFinder finder) => finder.Find<PasswordFieldDriver>();
    }
}
