using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class BlogDetailLayout : ComponentBase
    {
        public GridDriver BlogGridGrid => ByCssSelector("div[data-name='BlogGrid']").Wait();
        public LabelFieldDriver BlogLabel => ByCssSelector("div[data-name='BlogLabel']").Wait();
        public LabelFieldDriver BlogNameLabel => ByCssSelector("div[data-name='BlogNameLabel']").Wait();
        public TextFieldDriver BlogName => ByCssSelector("div[data-name='BlogName']").Wait();
        public LabelFieldDriver OwnerLabel => ByCssSelector("div[data-name='OwnerLabel']").Wait();
        public LinkFieldDriver<BlogOwnerListLayout, BlogOwnerSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public TextFieldDriver Link_Name => ByCssSelector("div[data-name='Link.Name']").Wait();
        public LabelFieldDriver Label => ByCssSelector("div[data-name='Label']").Wait();
        public ListFieldDriver<BlogPostListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public BlogDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator BlogDetailLayout(ElementFinder finder) => finder.Find<BlogDetailLayout>();
    }

    public class BlogDetailPage : DetailPage<BlogDetailLayout>
    {

        public BlogDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class BlogDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Blog/")]
        public static BlogDetailPage AttachBlogDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Blog/");
            return new BlogDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<BlogDetailLayout> AttachBlogDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Blog']").Wait();

    }

}
