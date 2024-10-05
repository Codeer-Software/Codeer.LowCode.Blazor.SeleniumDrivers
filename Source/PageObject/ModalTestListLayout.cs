using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ModalTestListLayout : ListLayoutBase
    {

        public ModalTestListLayout(IWebElement element) : base(element) { }

        public static implicit operator ModalTestListLayout(ElementFinder finder) => finder.Find<ModalTestListLayout>();
    }

}
