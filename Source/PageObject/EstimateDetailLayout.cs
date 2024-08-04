using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateDetailLayout : ComponentBase
    {
        public AnchorTagFieldDriver AnchorTag => ByCssSelector("div[data-name='AnchorTag']").Wait();
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public ButtonFieldDriver PdfButton => ByCssSelector("div[data-name='PdfButton']").Wait();
        public LabelFieldDriver TitleLabel1 => ByCssSelector("div[data-name='TitleLabel1']").Wait();
        public TextFieldDriver Title => ByCssSelector("div[data-name='Title']").Wait();
        public LabelFieldDriver ClientLabel => ByCssSelector("div[data-name='ClientLabel']").Wait();
        public LinkFieldDriver<EstimateClientCompanyListLayout, EstimateClientCompanySearchLayout> Client => ByCssSelector("div[data-name='Client']").Wait();
        public LabelFieldDriver ContactPersonLabel => ByCssSelector("div[data-name='ContactPersonLabel']").Wait();
        public LinkFieldDriver<EstimateContactPersonListLayout, EstimateContactPersonSearchLayout> ContactPerson => ByCssSelector("div[data-name='ContactPerson']").Wait();
        public LabelFieldDriver TotalLabel => ByCssSelector("div[data-name='TotalLabel']").Wait();
        public NumberFieldDriver Total => ByCssSelector("div[data-name='Total']").Wait();
        public LabelFieldDriver TaxLabel => ByCssSelector("div[data-name='TaxLabel']").Wait();
        public NumberFieldDriver Tax => ByCssSelector("div[data-name='Tax']").Wait();
        public LabelFieldDriver TotalInTaxLabel => ByCssSelector("div[data-name='TotalInTaxLabel']").Wait();
        public NumberFieldDriver TotalInTax => ByCssSelector("div[data-name='TotalInTax']").Wait();
        public ListFieldDriver<EstimateDetailListLayout> ListEstimateDetail => ByCssSelector("div[data-name='ListEstimateDetail']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public EstimateDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateDetailLayout(ElementFinder finder) => finder.Find<EstimateDetailLayout>();
    }

    public class EstimateDetailPage : DetailPage<EstimateDetailLayout>
    {

        public EstimateDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Estimate/")]
        public static EstimateDetailPage AttachEstimateDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Estimate/");
            return new EstimateDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<EstimateDetailLayout> AttachEstimateDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Estimate']").Wait();

    }

}
