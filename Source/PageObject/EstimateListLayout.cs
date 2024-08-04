using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateListLayout : ListLayoutBase
    {
        public TextFieldDriver Title => ByCssSelector("td[data-name='Title']").Wait();
        public LinkFieldDriver<EstimateClientCompanyListLayout, EstimateClientCompanySearchLayout> Client => ByCssSelector("td[data-name='Client']").Wait();
        public DateTimeFieldDriver CreatedAt => ByCssSelector("td[data-name='CreatedAt']").Wait();
        public DateTimeFieldDriver UpdatedAt => ByCssSelector("td[data-name='UpdatedAt']").Wait();

        public EstimateListLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateListLayout(ElementFinder finder) => finder.Find<EstimateListLayout>();
    }

    public class EstimateListPage : ListPage<EstimateListLayout, EstimateSearchLayout>
    {

        public EstimateListPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Estimate")]
        public static EstimateListPage AttachEstimateListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Estimate");
            return new EstimateListPage(driver);
        }

    }

}
