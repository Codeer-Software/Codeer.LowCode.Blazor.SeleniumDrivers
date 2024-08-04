using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class RankListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver RankName => ByCssSelector("td[data-name='RankName']").Wait();

        public RankListLayout(IWebElement element) : base(element) { }

        public static implicit operator RankListLayout(ElementFinder finder) => finder.Find<RankListLayout>();
    }

    public class RankListPage : ListPage<RankListLayout, RankSearchLayout>
    {

        public RankListPage(IWebDriver driver) : base(driver) { }

    }

    public static class RankListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Rank")]
        public static RankListPage AttachRankListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Rank");
            return new RankListPage(driver);
        }

    }

}
