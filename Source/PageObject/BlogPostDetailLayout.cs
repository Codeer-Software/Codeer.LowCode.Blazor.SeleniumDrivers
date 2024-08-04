using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogPostDetailLayout : ComponentBase
    {
        public LabelFieldDriver Label2 => ByCssSelector("div[data-name='Label2']").Wait();
        public LabelFieldDriver Label => ByCssSelector("div[data-name='Label']").Wait();
        public TextFieldDriver Subject => ByCssSelector("div[data-name='Subject']").Wait();
        public LabelFieldDriver Label1 => ByCssSelector("div[data-name='Label1']").Wait();
        public TextFieldDriver Content => ByCssSelector("div[data-name='Content']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public BlogPostDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogPostDetailLayout(ElementFinder finder) => finder.Find<BlogPostDetailLayout>();
    }

    public class BlogPostDetailPage : DetailPage<BlogPostDetailLayout>
    {

        public BlogPostDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class BlogPostDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/BlogPost/")]
        public static BlogPostDetailPage AttachBlogPostDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/BlogPost/");
            return new BlogPostDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<BlogPostDetailLayout> AttachBlogPostDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='BlogPost']").Wait();

    }

}
