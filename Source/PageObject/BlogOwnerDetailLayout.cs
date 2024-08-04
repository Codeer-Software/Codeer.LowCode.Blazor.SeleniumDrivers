using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogOwnerDetailLayout : ComponentBase
    {
        public LabelFieldDriver ブログオーナーLabel => ByCssSelector("div[data-name='ブログオーナーLabel']").Wait();
        public LabelFieldDriver UserIdLabel => ByCssSelector("div[data-name='UserIdLabel']").Wait();
        public IdFieldDriver Id => ByCssSelector("div[data-name='Id']").Wait();
        public LabelFieldDriver UserNameLabel => ByCssSelector("div[data-name='UserNameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public SubmitButtonFieldDriver 登録ボタン => ByCssSelector("div[data-name='登録ボタン']").Wait();

        public BlogOwnerDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogOwnerDetailLayout(ElementFinder finder) => finder.Find<BlogOwnerDetailLayout>();
    }

    public class BlogOwnerDetailPage : DetailPage<BlogOwnerDetailLayout>
    {

        public BlogOwnerDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class BlogOwnerDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/BlogOwner/")]
        public static BlogOwnerDetailPage AttachBlogOwnerDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/BlogOwner/");
            return new BlogOwnerDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<BlogOwnerDetailLayout> AttachBlogOwnerDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='BlogOwner']").Wait();

    }

}
