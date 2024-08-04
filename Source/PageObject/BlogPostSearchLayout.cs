using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogPostSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public TextFieldSearchDriver Content => ByCssSelector("div[data-name='Content']").Wait();

        public BlogPostSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogPostSearchLayout(ElementFinder finder) => finder.Find<BlogPostSearchLayout>();
    }

}
