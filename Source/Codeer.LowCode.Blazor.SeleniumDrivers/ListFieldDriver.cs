using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ListFieldDriver<T> : ComponentBase where T : ListLayoutBase
    {
        public ButtonDriver Create => ByCssSelector("button[data-system='create']").Wait();
        public ItemsControlDriver<T> Items => Element.FindNext(By.CssSelector("table tbody")).Wait().Find<ItemsControlDriver<T>>();
        public PagerDriver Pager => ByCssSelector("[role='navigation'] ul.pagination").Wait();
        public ListFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ListFieldDriver<T>(ElementFinder finder) => finder.Find<ListFieldDriver<T>>();
    }
}
