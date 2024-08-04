using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DestinationsDetailLayout : ComponentBase
    {
        public LabelFieldDriver Label目的地 => ByCssSelector("div[data-name='Label目的地']").Wait();
        public TextFieldDriver Name目的地 => ByCssSelector("div[data-name='Name目的地']").Wait();

        public DestinationsDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator DestinationsDetailLayout(ElementFinder finder) => finder.Find<DestinationsDetailLayout>();
    }

    public class DestinationsDetailPage : DetailPage<DestinationsDetailLayout>
    {

        public DestinationsDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class DestinationsDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Destinations")]
        public static DestinationsDetailPage AttachDestinationsDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Destinations");
            return new DestinationsDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<DestinationsDetailLayout> AttachDestinationsDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Destinations']").Wait();

    }

}
