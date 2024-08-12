using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SearchFieldDriver<T> : ComponentBase
        where T : ComponentBase
    {
        public T Fields => Element.FindNext(By.TagName("form")).Find<T>();
        public ButtonDriver Search => ByCssSelector("input[data-system='search']").Wait();
        public ButtonDriver Clear => ByCssSelector("input[data-system='clear']").Wait();
        public SearchFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator SearchFieldDriver<T>(ElementFinder finder) =>
            finder.Find<SearchFieldDriver<T>>();
    }
}
