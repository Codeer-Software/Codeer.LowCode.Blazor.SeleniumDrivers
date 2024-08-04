using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DialogDetailLayout : ComponentBase
    {
        public DateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();

        public DialogDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator DialogDetailLayout(ElementFinder finder) => finder.Find<DialogDetailLayout>();
    }

    public class DialogDetailPage : DetailPage<DialogDetailLayout>
    {

        public DialogDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class DialogDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Dialog")]
        public static DialogDetailPage AttachDialogDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Dialog");
            return new DialogDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<DialogDetailLayout> AttachDialogDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Dialog']").Wait();

    }

}
