using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class DetailListFieldDriver<TDetailLayout> : ComponentBase
        where TDetailLayout : ComponentBase
    {
        public AnchorDriver Create => ByCssSelector("button[data-system='create']").Wait();
        public ItemsControlDriver<TDetailLayout> Items => ByCssSelector(".detail-container").Wait().Find<ItemsControlDriver<TDetailLayout>>();
        public PagerDriver Pager => ByCssSelector("[role='navigation'] ul.pagination").Wait();
        public DetailListFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator DetailListFieldDriver<TDetailLayout>(ElementFinder finder) =>
            finder.Find<DetailListFieldDriver<TDetailLayout>>();
    }
}
