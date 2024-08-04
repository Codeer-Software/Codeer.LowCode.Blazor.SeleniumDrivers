using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TeaDetailLayout : ComponentBase
    {
        public LabelFieldDriver 紅茶タイトル => ByCssSelector("div[data-name='紅茶タイトル']").Wait();
        public LabelFieldDriver Label名前 => ByCssSelector("div[data-name='Label名前']").Wait();
        public TextFieldDriver 名前 => ByCssSelector("div[data-name='名前']").Wait();
        public LabelFieldDriver Label説明 => ByCssSelector("div[data-name='Label説明']").Wait();
        public TextFieldDriver 説明 => ByCssSelector("div[data-name='説明']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public TeaDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator TeaDetailLayout(ElementFinder finder) => finder.Find<TeaDetailLayout>();
    }

    public class TeaDetailLayout_テスト用詳細 : ComponentBase
    {
        public LabelFieldDriver Label名前 => ByCssSelector("div[data-name='Label名前']").Wait();
        public TextFieldDriver 名前 => ByCssSelector("div[data-name='名前']").Wait();
        public LabelFieldDriver Label説明 => ByCssSelector("div[data-name='Label説明']").Wait();
        public TextFieldDriver 説明 => ByCssSelector("div[data-name='説明']").Wait();

        public TeaDetailLayout_テスト用詳細(IWebElement element) : base(element) { }

        public static implicit operator TeaDetailLayout_テスト用詳細(ElementFinder finder) => finder.Find<TeaDetailLayout_テスト用詳細>();
    }

    public class TeaDetailPage : DetailPage<TeaDetailLayout>
    {

        public TeaDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class TeaDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Tea/")]
        public static TeaDetailPage AttachTeaDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Tea/");
            return new TeaDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<TeaDetailLayout> AttachTeaDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Tea']").Wait();

    }

}
