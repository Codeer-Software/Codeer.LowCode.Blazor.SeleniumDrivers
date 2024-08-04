using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateHomeListLayout : ListLayoutBase
    {

        public EstimateHomeListLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateHomeListLayout(ElementFinder finder) => finder.Find<EstimateHomeListLayout>();
    }

}
