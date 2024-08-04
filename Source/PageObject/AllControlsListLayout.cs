using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class AllControlsListLayout : ListLayoutBase
    {

        public AllControlsListLayout(IWebElement element) : base(element) { }

        public static implicit operator AllControlsListLayout(ElementFinder finder) => finder.Find<AllControlsListLayout>();
    }

}
