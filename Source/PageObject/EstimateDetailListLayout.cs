using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateDetailListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();
        public TextFieldDriver Remarks => ByCssSelector("td[data-name='Remarks']").Wait();
        public NumberFieldDriver Amount => ByCssSelector("td[data-name='Amount']").Wait();

        public EstimateDetailListLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateDetailListLayout(ElementFinder finder) => finder.Find<EstimateDetailListLayout>();
    }

    public class EstimateDetailListPage : ListPage<EstimateDetailListLayout, EstimateDetailSearchLayout>
    {

        public EstimateDetailListPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateDetailListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/EstimateDetail")]
        public static EstimateDetailListPage AttachEstimateDetailListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/EstimateDetail");
            return new EstimateDetailListPage(driver);
        }

    }

}
