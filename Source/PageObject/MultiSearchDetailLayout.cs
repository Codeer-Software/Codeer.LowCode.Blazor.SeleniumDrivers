using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class MultiSearchDetailLayout : ComponentBase
    {

        public MultiSearchDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator MultiSearchDetailLayout(ElementFinder finder) => finder.Find<MultiSearchDetailLayout>();
    }

    public class MultiSearchDetailPage : DetailPage<MultiSearchDetailLayout>
    {

        public MultiSearchDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class MultiSearchDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/MultiSearch/")]
        public static MultiSearchDetailPage AttachMultiSearchDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/MultiSearch/");
            return new MultiSearchDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<MultiSearchDetailLayout> AttachMultiSearchDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='MultiSearch']").Wait();

    }

}
