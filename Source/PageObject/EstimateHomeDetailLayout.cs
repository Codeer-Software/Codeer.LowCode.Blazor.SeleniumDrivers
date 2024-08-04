using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateHomeDetailLayout : ComponentBase
    {
        public LabelFieldDriver Title => ByCssSelector("div[data-name='Title']").Wait();

        public EstimateHomeDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateHomeDetailLayout(ElementFinder finder) => finder.Find<EstimateHomeDetailLayout>();
    }

    public class EstimateHomeDetailPage : DetailPage<EstimateHomeDetailLayout>
    {

        public EstimateHomeDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateHomeDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/EstimateHome")]
        public static EstimateHomeDetailPage AttachEstimateHomeDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/EstimateHome");
            return new EstimateHomeDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<EstimateHomeDetailLayout> AttachEstimateHomeDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='EstimateHome']").Wait();

    }

}
