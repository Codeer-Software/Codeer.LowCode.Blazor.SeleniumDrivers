using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ModalTestSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public ModalTestSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ModalTestSearchLayout(ElementFinder finder) => finder.Find<ModalTestSearchLayout>();
    }

}
