using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class PrefectureListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();
        public SelectFieldDriver District => ByCssSelector("td[data-name='District']").Wait();

        public PrefectureListLayout(IWebElement element) : base(element) { }

        public static implicit operator PrefectureListLayout(ElementFinder finder) => finder.Find<PrefectureListLayout>();
    }

    public class PrefectureListPage : ListPage<PrefectureListLayout, PrefectureSearchLayout>
    {

        public PrefectureListPage(IWebDriver driver) : base(driver) { }

    }

    public static class PrefectureListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Prefecture")]
        public static PrefectureListPage AttachPrefectureListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Prefecture");
            return new PrefectureListPage(driver);
        }

    }

}
