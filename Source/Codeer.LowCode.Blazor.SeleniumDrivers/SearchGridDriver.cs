using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SearchGridDriver : ComponentBase
    {
        public ButtonDriver Expander => ByCssSelector("[data-system='expander']").Wait();
        public DropDownListDriver MatchType => ByCssSelector("[data-system='search-condition-field'] select").Wait();
        public SearchGridDriver(IWebElement element) : base(element) { }
        public static implicit operator SearchGridDriver(ElementFinder finder) => finder.Find<SearchGridDriver>();
    }
}
