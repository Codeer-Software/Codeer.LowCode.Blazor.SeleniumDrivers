using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogPostListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Subject => ByCssSelector("td[data-name='Subject']").Wait();

        public BlogPostListLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogPostListLayout(ElementFinder finder) => finder.Find<BlogPostListLayout>();
    }

    public class BlogPostListPage : ListPage<BlogPostListLayout, BlogPostSearchLayout>
    {

        public BlogPostListPage(IWebDriver driver) : base(driver) { }

    }

    public static class BlogPostListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/BlogPost")]
        public static BlogPostListPage AttachBlogPostListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/BlogPost");
            return new BlogPostListPage(driver);
        }

    }

}
