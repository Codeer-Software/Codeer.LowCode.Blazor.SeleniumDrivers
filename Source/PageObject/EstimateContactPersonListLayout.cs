using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateContactPersonListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();
        public TextFieldDriver Email => ByCssSelector("td[data-name='Email']").Wait();

        public EstimateContactPersonListLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateContactPersonListLayout(ElementFinder finder) => finder.Find<EstimateContactPersonListLayout>();
    }

    public class EstimateContactPersonListPage : ListPage<EstimateContactPersonListLayout, EstimateContactPersonSearchLayout>
    {

        public EstimateContactPersonListPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateContactPersonListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/EstimateContactPerson")]
        public static EstimateContactPersonListPage AttachEstimateContactPersonListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/EstimateContactPerson");
            return new EstimateContactPersonListPage(driver);
        }

    }

}
