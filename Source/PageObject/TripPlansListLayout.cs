using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TripPlansListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();
        public NumberFieldDriver Budget => ByCssSelector("td[data-name='Budget']").Wait();
        public DateTimeFieldDriver CreatedAt => ByCssSelector("td[data-name='CreatedAt']").Wait();

        public TripPlansListLayout(IWebElement element) : base(element) { }

        public static implicit operator TripPlansListLayout(ElementFinder finder) => finder.Find<TripPlansListLayout>();
    }

    public class TripPlansListPage : ListPage<TripPlansListLayout, TripPlansSearchLayout>
    {

        public TripPlansListPage(IWebDriver driver) : base(driver) { }

    }

    public static class TripPlansListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/TripPlans")]
        public static TripPlansListPage AttachTripPlansListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/TripPlans");
            return new TripPlansListPage(driver);
        }

    }

}
