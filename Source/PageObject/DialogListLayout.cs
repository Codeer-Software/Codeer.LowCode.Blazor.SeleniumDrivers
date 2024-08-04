using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DialogListLayout : ListLayoutBase
    {

        public DialogListLayout(IWebElement element) : base(element) { }

        public static implicit operator DialogListLayout(ElementFinder finder) => finder.Find<DialogListLayout>();
    }

}
