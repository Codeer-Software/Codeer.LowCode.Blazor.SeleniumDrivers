using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class LinkFieldDriver<TListLayout, TSearchLayout> : ComponentBase where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public ButtonDriver Close => GetModal().ByCssSelector("button[data-system='close-modal']").Wait();
        public ButtonDriver Clear => ByCssSelector("button[data-system='clear-link-text']").Wait();
        public ButtonDriver Search => ByCssSelector(".input-group button:has(.bi-search)").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public SearchFieldDriver<TSearchLayout> LinkSearch => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> LinkList => GetModal().ByCssSelector("div[data-system='list-field']").Wait();
        public LinkFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator LinkFieldDriver<TListLayout, TSearchLayout>(ElementFinder finder) => finder.Find<LinkFieldDriver<TListLayout, TSearchLayout>>();
        private ElementFinder GetModal() => new ElementFinder(Element.FindElement(By.XPath("/html/body")).FindElement(By.CssSelector("div.modal.show")));
    }
}
