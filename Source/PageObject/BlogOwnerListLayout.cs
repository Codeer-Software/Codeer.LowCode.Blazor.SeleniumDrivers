using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogOwnerListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public BlogOwnerListLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogOwnerListLayout(ElementFinder finder) => finder.Find<BlogOwnerListLayout>();
    }

    public class BlogOwnerListPage : ListPage<BlogOwnerListLayout, BlogOwnerSearchLayout>
    {

        public BlogOwnerListPage(IWebDriver driver) : base(driver) { }

    }

    public static class BlogOwnerListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/BlogOwner")]
        public static BlogOwnerListPage AttachBlogOwnerListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/BlogOwner");
            return new BlogOwnerListPage(driver);
        }

    }

}
