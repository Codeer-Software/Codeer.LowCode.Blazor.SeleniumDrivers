using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver BlogName => ByCssSelector("td[data-name='BlogName']").Wait();

        public BlogListLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogListLayout(ElementFinder finder) => finder.Find<BlogListLayout>();
    }

    public class BlogListPage : ListPage<BlogListLayout, BlogSearchLayout>
    {

        public BlogListPage(IWebDriver driver) : base(driver) { }

    }

    public static class BlogListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Blog")]
        public static BlogListPage AttachBlogListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Blog");
            return new BlogListPage(driver);
        }

    }

}
