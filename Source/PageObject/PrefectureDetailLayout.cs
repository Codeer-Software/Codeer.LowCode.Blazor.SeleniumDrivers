using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class PrefectureDetailLayout : ComponentBase
    {
        public LabelFieldDriver Label都道府県名 => ByCssSelector("div[data-name='Label都道府県名']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver Label地域名 => ByCssSelector("div[data-name='Label地域名']").Wait();
        public SelectFieldDriver District => ByCssSelector("div[data-name='District']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public PrefectureDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator PrefectureDetailLayout(ElementFinder finder) => finder.Find<PrefectureDetailLayout>();
    }

    public class PrefectureDetailLayout_ForDetailList : ComponentBase
    {
        public LabelFieldDriver Label都道府県名 => ByCssSelector("div[data-name='Label都道府県名']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver Label地域名 => ByCssSelector("div[data-name='Label地域名']").Wait();
        public SelectFieldDriver District => ByCssSelector("div[data-name='District']").Wait();

        public PrefectureDetailLayout_ForDetailList(IWebElement element) : base(element) { }

        public static implicit operator PrefectureDetailLayout_ForDetailList(ElementFinder finder) => finder.Find<PrefectureDetailLayout_ForDetailList>();
    }

    public class PrefectureDetailLayout_TileLayout : ComponentBase
    {
        public LabelFieldDriver Label都道府県名 => ByCssSelector("div[data-name='Label都道府県名']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver Label地域名 => ByCssSelector("div[data-name='Label地域名']").Wait();
        public SelectFieldDriver District => ByCssSelector("div[data-name='District']").Wait();

        public PrefectureDetailLayout_TileLayout(IWebElement element) : base(element) { }

        public static implicit operator PrefectureDetailLayout_TileLayout(ElementFinder finder) => finder.Find<PrefectureDetailLayout_TileLayout>();
    }

    public class PrefectureDetailPage : DetailPage<PrefectureDetailLayout>
    {

        public PrefectureDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class PrefectureDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Prefecture/")]
        public static PrefectureDetailPage AttachPrefectureDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Prefecture/");
            return new PrefectureDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<PrefectureDetailLayout> AttachPrefectureDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Prefecture']").Wait();

    }

}
