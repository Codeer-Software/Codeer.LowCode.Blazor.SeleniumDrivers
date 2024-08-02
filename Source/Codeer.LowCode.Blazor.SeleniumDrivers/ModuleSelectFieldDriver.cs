using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ModuleSelectFieldDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public ModuleSelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ModuleSelectFieldDriver(ElementFinder finder) =>
            finder.Find<ModuleSelectFieldDriver>();
    }
}
