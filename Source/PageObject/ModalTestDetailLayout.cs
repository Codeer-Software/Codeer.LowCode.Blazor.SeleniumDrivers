using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ModalTestDetailLayout : ComponentBase
    {
        public ButtonFieldDriver ButtonMessageBox => ByCssSelector("div[data-name='ButtonMessageBox']").Wait();
        public ButtonFieldDriver ButtonDialog => ByCssSelector("div[data-name='ButtonDialog']").Wait();

        public ModalTestDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ModalTestDetailLayout(ElementFinder finder) => finder.Find<ModalTestDetailLayout>();
    }

    public class ModalTestDetailPage : DetailPage<ModalTestDetailLayout>
    {

        public ModalTestDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ModalTestDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ModalTest")]
        public static ModalTestDetailPage AttachModalTestDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ModalTest");
            return new ModalTestDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ModalTestDetailLayout> AttachModalTestDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ModalTest']").Wait();

    }

}
