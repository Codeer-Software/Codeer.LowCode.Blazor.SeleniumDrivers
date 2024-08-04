using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldTestDetailLayout : ComponentBase
    {
        public LabelFieldDriver Label => ByCssSelector("div[data-name='Label']").Wait();
        public LabelFieldDriver LabelTextField => ByCssSelector("div[data-name='LabelTextField']").Wait();
        public TextFieldDriver テキストフィールド => ByCssSelector("div[data-name='テキストフィールド']").Wait();
        public LabelFieldDriver Label真偽値 => ByCssSelector("div[data-name='Label真偽値']").Wait();
        public BooleanFieldDriver 真偽値フィールド => ByCssSelector("div[data-name='真偽値フィールド']").Wait();
        public LabelFieldDriver Label開始日 => ByCssSelector("div[data-name='Label開始日']").Wait();
        public DateFieldDriver 開始日 => ByCssSelector("div[data-name='開始日']").Wait();
        public LabelFieldDriver Label設定日時 => ByCssSelector("div[data-name='Label設定日時']").Wait();
        public DateTimeFieldDriver 設定日時 => ByCssSelector("div[data-name='設定日時']").Wait();
        public DetailListFieldDriver<TeaDetailLayout_テスト用詳細> 紅茶詳細リスト => ByCssSelector("div[data-name='紅茶詳細リスト']").Wait();
        public SubmitButtonFieldDriver SubmitButton保存 => ByCssSelector("div[data-name='SubmitButton保存']").Wait();

        public FieldTestDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldTestDetailLayout(ElementFinder finder) => finder.Find<FieldTestDetailLayout>();
    }

    public class FieldTestDetailPage : DetailPage<FieldTestDetailLayout>
    {

        public FieldTestDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class FieldTestDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/FieldTest/")]
        public static FieldTestDetailPage AttachFieldTestDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/FieldTest/");
            return new FieldTestDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<FieldTestDetailLayout> AttachFieldTestDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='FieldTest']").Wait();

    }

}
