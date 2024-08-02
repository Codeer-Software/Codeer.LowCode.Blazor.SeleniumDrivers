using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SearchFieldDriver<T> : ComponentBase
        where T : ComponentBase
    {
        public T Fields => this.As<T>();
        public ButtonDriver Search => ByCssSelector("input[data-system='search']").Wait();
        public ButtonDriver Clear => ByCssSelector("input[data-system='clear']").Wait();
        public SearchFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator SearchFieldDriver<T>(ElementFinder finder) =>
            finder.Find<SearchFieldDriver<T>>();
    }

    internal static class ElementExtension
    {
        public static T As<T>(this ComponentBase component) where T : ComponentBase
            => new ElementFinder(component.Element).Find<T>();
    }
}
