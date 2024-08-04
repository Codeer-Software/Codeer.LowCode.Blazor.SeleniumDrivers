using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TagListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver TagText => ByCssSelector("td[data-name='TagText']").Wait();

        public TagListLayout(IWebElement element) : base(element) { }

        public static implicit operator TagListLayout(ElementFinder finder) => finder.Find<TagListLayout>();
    }

    public class TagListPage : ListPage<TagListLayout, TagSearchLayout>
    {

        public TagListPage(IWebDriver driver) : base(driver) { }

    }

    public static class TagListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Tag")]
        public static TagListPage AttachTagListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Tag");
            return new TagListPage(driver);
        }

    }

}
