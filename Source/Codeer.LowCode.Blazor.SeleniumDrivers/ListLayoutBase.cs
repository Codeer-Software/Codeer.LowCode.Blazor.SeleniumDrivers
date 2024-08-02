using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ListLayoutBase : ComponentBase
    {
        public AnchorDriver NavigateToDetail => ByCssSelector("a.btn.btn-outline-secondary").Wait();
        public ButtonDriver MoveUp => ByCssSelector("[data-system='move-up']").Wait();
        public ButtonDriver MoveDown => ByCssSelector("[data-system='move-down']").Wait();
        public ButtonDriver Delete => ByCssSelector("[data-system='delete']").Wait();
        public ListLayoutBase(IWebElement element) : base(element) { }
        public static implicit operator ListLayoutBase(ElementFinder finder) => finder.Find<ListLayoutBase>();
    }
}
