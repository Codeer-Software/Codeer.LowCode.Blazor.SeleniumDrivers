using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class TileListFieldDriver<TDetailLayout> : ComponentBase where TDetailLayout : ComponentBase
    {
        public AnchorDriver Create => ByCssSelector("a[data-system='create']").Wait();
        public ItemsControlDriver<TDetailLayout> Items => ByCssSelector(".tile-container").Wait().Find<ItemsControlDriver<TDetailLayout>>();
        public PagerDriver Pager => ByCssSelector("[role='navigation'] ul.pagination").Wait();
        public TileListFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator TileListFieldDriver<TDetailLayout>(ElementFinder finder) =>
            finder.Find<TileListFieldDriver<TDetailLayout>>();
    }
}
