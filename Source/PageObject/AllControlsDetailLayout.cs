using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class AllControlsDetailLayout : ComponentBase
    {
        public GridDriver Grid1Grid => ByCssSelector("div[data-name='Grid1']").Wait();
        public TabDriver Tab1Tab => ByCssSelector("div[data-name='Tab1']").Wait();
        public AnchorTagFieldDriver AnchorTag => ByCssSelector("div[data-name='AnchorTag']").Wait();
        public BooleanFieldDriver Boolean => ByCssSelector("div[data-name='Boolean']").Wait();
        public BooleanFieldDriver Boolean1 => ByCssSelector("div[data-name='Boolean1']").Wait();
        public BooleanFieldDriver Boolean2 => ByCssSelector("div[data-name='Boolean2']").Wait();
        public ButtonFieldDriver Button => ByCssSelector("div[data-name='Button']").Wait();
        public DateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public IdFieldDriver Id => ByCssSelector("div[data-name='Id']").Wait();
        public ImageViewerFieldDriver ImageViewer => ByCssSelector("div[data-name='ImageViewer']").Wait();
        public LabelFieldDriver LabelX => ByCssSelector("div[data-name='LabelX']").Wait();
        public LinkFieldDriver<BlogPostListLayout, BlogPostSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public ModuleSelectFieldDriver ModuleSelect => ByCssSelector("div[data-name='ModuleSelect']").Wait();
        public NumberFieldDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public OptimisticLockingFieldDriver OptimisticLocking => ByCssSelector("div[data-name='OptimisticLocking']").Wait();
        public PasswordFieldDriver Password => ByCssSelector("div[data-name='Password']").Wait();
        public RadioButtonFieldDriver RadioButton => ByCssSelector("div[data-name='RadioButton']").Wait();
        public RadioButtonFieldDriver RadioButton1 => ByCssSelector("div[data-name='RadioButton1']").Wait();
        public SelectFieldDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public TimeFieldDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public SearchFieldDriver<BlogPostSearchLayout> Search => ByCssSelector("div[data-name='Search']").Wait();
        public ListFieldDriver<BlogPostListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public TileListFieldDriver<BlogPostDetailLayout> TileList => ByCssSelector("div[data-name='TileList']").Wait();
        public DetailListFieldDriver<BlogPostDetailLayout> DetailList => ByCssSelector("div[data-name='DetailList']").Wait();
        public ModuleFieldDriver<BlogPostDetailLayout> Module => ByCssSelector("div[data-name='Module']").Wait();
        public TextFieldDriver Text1 => ByCssSelector("div[data-name='Text1']").Wait();
        public TextFieldDriver Text2 => ByCssSelector("div[data-name='Text2']").Wait();
        public TimeFieldDriver Time1 => ByCssSelector("div[data-name='Time1']").Wait();

        public AllControlsDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator AllControlsDetailLayout(ElementFinder finder) => finder.Find<AllControlsDetailLayout>();
    }

    public class AllControlsDetailPage : DetailPage<AllControlsDetailLayout>
    {

        public AllControlsDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class AllControlsDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/AllControls")]
        public static AllControlsDetailPage AttachAllControlsDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/AllControls");
            return new AllControlsDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<AllControlsDetailLayout> AttachAllControlsDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='AllControls']").Wait();

    }

}
