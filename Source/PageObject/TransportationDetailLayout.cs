using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TransportationDetailLayout : ComponentBase
    {

        public TransportationDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator TransportationDetailLayout(ElementFinder finder) => finder.Find<TransportationDetailLayout>();
    }

    public class TransportationDetailPage : DetailPage<TransportationDetailLayout>
    {

        public TransportationDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class TransportationDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Transportation/")]
        public static TransportationDetailPage AttachTransportationDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Transportation/");
            return new TransportationDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<TransportationDetailLayout> AttachTransportationDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Transportation']").Wait();

    }

}
