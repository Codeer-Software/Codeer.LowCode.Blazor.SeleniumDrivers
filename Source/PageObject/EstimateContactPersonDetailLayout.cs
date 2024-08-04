using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateContactPersonDetailLayout : ComponentBase
    {
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver EmailLabel => ByCssSelector("div[data-name='EmailLabel']").Wait();
        public TextFieldDriver Email => ByCssSelector("div[data-name='Email']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public EstimateContactPersonDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator EstimateContactPersonDetailLayout(ElementFinder finder) => finder.Find<EstimateContactPersonDetailLayout>();
    }

    public class EstimateContactPersonDetailPage : DetailPage<EstimateContactPersonDetailLayout>
    {

        public EstimateContactPersonDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class EstimateContactPersonDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/EstimateContactPerson/")]
        public static EstimateContactPersonDetailPage AttachEstimateContactPersonDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/EstimateContactPerson/");
            return new EstimateContactPersonDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<EstimateContactPersonDetailLayout> AttachEstimateContactPersonDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='EstimateContactPerson']").Wait();

    }

}
