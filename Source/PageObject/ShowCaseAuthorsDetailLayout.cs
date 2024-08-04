using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ShowCaseAuthorsDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelEメール => ByCssSelector("div[data-name='LabelEメール']").Wait();
        public TextFieldDriver Email => ByCssSelector("div[data-name='Email']").Wait();
        public LabelFieldDriver Labelユーザー名 => ByCssSelector("div[data-name='Labelユーザー名']").Wait();
        public TextFieldDriver Username => ByCssSelector("div[data-name='Username']").Wait();
        public LabelFieldDriver Labelパスワード => ByCssSelector("div[data-name='Labelパスワード']").Wait();
        public TextFieldDriver Password1 => ByCssSelector("div[data-name='Password1']").Wait();

        public ShowCaseAuthorsDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ShowCaseAuthorsDetailLayout(ElementFinder finder) => finder.Find<ShowCaseAuthorsDetailLayout>();
    }

    public class ShowCaseAuthorsDetailPage : DetailPage<ShowCaseAuthorsDetailLayout>
    {

        public ShowCaseAuthorsDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ShowCaseAuthorsDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ShowCaseAuthors/")]
        public static ShowCaseAuthorsDetailPage AttachShowCaseAuthorsDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ShowCaseAuthors/");
            return new ShowCaseAuthorsDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ShowCaseAuthorsDetailLayout> AttachShowCaseAuthorsDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ShowCaseAuthors']").Wait();

    }

}
