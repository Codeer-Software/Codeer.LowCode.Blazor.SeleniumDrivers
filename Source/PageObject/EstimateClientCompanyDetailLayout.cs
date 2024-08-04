using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateClientCompanyDetailLayout : ComponentBase
    {
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver AddressLabel => ByCssSelector("div[data-name='AddressLabel']").Wait();
        public TextFieldDriver Address => ByCssSelector("div[data-name='Address']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public EstimateClientCompanyDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateClientCompanyDetailLayout(ElementFinder finder) => finder.Find<EstimateClientCompanyDetailLayout>();
    }

    public class EstimateClientCompanyDetailPage : DetailPage<EstimateClientCompanyDetailLayout>
    {

        public EstimateClientCompanyDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateClientCompanyDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/EstimateClientCompany/")]
        public static EstimateClientCompanyDetailPage AttachEstimateClientCompanyDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/EstimateClientCompany/");
            return new EstimateClientCompanyDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<EstimateClientCompanyDetailLayout> AttachEstimateClientCompanyDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='EstimateClientCompany']").Wait();

    }

}
