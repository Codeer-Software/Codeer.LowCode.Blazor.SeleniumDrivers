using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateClientCompanyListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();
        public TextFieldDriver Address => ByCssSelector("td[data-name='Address']").Wait();

        public EstimateClientCompanyListLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateClientCompanyListLayout(ElementFinder finder) => finder.Find<EstimateClientCompanyListLayout>();
    }

    public class EstimateClientCompanyListPage : ListPage<EstimateClientCompanyListLayout, EstimateClientCompanySearchLayout>
    {

        public EstimateClientCompanyListPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateClientCompanyListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/EstimateClientCompany")]
        public static EstimateClientCompanyListPage AttachEstimateClientCompanyListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/EstimateClientCompany");
            return new EstimateClientCompanyListPage(driver);
        }

    }

}
