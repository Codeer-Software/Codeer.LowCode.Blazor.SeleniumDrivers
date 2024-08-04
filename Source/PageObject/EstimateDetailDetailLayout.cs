using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateDetailDetailLayout : ComponentBase
    {
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver RemarksLabel => ByCssSelector("div[data-name='RemarksLabel']").Wait();
        public TextFieldDriver Remarks => ByCssSelector("div[data-name='Remarks']").Wait();
        public LabelFieldDriver AmountLabel => ByCssSelector("div[data-name='AmountLabel']").Wait();
        public NumberFieldDriver Amount => ByCssSelector("div[data-name='Amount']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public EstimateDetailDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateDetailDetailLayout(ElementFinder finder) => finder.Find<EstimateDetailDetailLayout>();
    }

    public class EstimateDetailDetailPage : DetailPage<EstimateDetailDetailLayout>
    {

        public EstimateDetailDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateDetailDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/EstimateDetail/")]
        public static EstimateDetailDetailPage AttachEstimateDetailDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/EstimateDetail/");
            return new EstimateDetailDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<EstimateDetailDetailLayout> AttachEstimateDetailDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='EstimateDetail']").Wait();

    }

}
