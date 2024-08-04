using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TagDetailLayout : ComponentBase
    {
        public LabelFieldDriver Label => ByCssSelector("div[data-name='Label']").Wait();
        public TextFieldDriver TagText => ByCssSelector("div[data-name='TagText']").Wait();

        public TagDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator TagDetailLayout(ElementFinder finder) => finder.Find<TagDetailLayout>();
    }

    public class TagDetailPage : DetailPage<TagDetailLayout>
    {

        public TagDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class TagDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Tag/")]
        public static TagDetailPage AttachTagDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Tag/");
            return new TagDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<TagDetailLayout> AttachTagDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Tag']").Wait();

    }

}
