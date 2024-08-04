using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ShowCaseDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelShowCase => ByCssSelector("div[data-name='LabelShowCase']").Wait();
        public LabelFieldDriver Label名前 => ByCssSelector("div[data-name='Label名前']").Wait();
        public LabelFieldDriver Label交通手段 => ByCssSelector("div[data-name='Label交通手段']").Wait();
        public RadioButtonFieldDriver RadioButtonRed => ByCssSelector("div[data-name='RadioButtonRed']").Wait();
        public RadioButtonFieldDriver RadioButtonYellow => ByCssSelector("div[data-name='RadioButtonYellow']").Wait();
        public RadioButtonFieldDriver RadioButtonGreen => ByCssSelector("div[data-name='RadioButtonGreen']").Wait();
        public PasswordFieldDriver Password => ByCssSelector("div[data-name='Password']").Wait();
        public ListFieldDriver<PrefectureListLayout> List都道府県 => ByCssSelector("div[data-name='List都道府県']").Wait();
        public AnchorTagFieldDriver AnchorTag => ByCssSelector("div[data-name='AnchorTag']").Wait();
        public ButtonFieldDriver Button => ByCssSelector("div[data-name='Button']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public RadioGroupFieldDriver RadioGroup_signal => ByCssSelector("div[data-name='RadioGroup_signal']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public BooleanFieldDriver BooleanSwitch => ByCssSelector("div[data-name='BooleanSwitch']").Wait();
        public ListNumberFieldDriver ListNumber => ByCssSelector("div[data-name='ListNumber']").Wait();
        public LinkFieldDriver<RankListLayout, RankSearchLayout> Linkランク => ByCssSelector("div[data-name='Linkランク']").Wait();
        public ImageViewerFieldDriver ImageViewer => ByCssSelector("div[data-name='ImageViewer']").Wait();
        public TileListFieldDriver<PrefectureDetailLayout_TileLayout> TileList => ByCssSelector("div[data-name='TileList']").Wait();
        public SubmitButtonFieldDriver 登録ボタン => ByCssSelector("div[data-name='登録ボタン']").Wait();
        public AnchorTagFieldDriver AnchorTagMV => ByCssSelector("div[data-name='AnchorTagMV']").Wait();
        public AnchorTagFieldDriver AnchorTagIV => ByCssSelector("div[data-name='AnchorTagIV']").Wait();
        public NumberFieldDriver Number数値 => ByCssSelector("div[data-name='Number数値']").Wait();

        public ShowCaseDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ShowCaseDetailLayout(ElementFinder finder) => finder.Find<ShowCaseDetailLayout>();
    }

    public class ShowCaseDetailPage : DetailPage<ShowCaseDetailLayout>
    {

        public ShowCaseDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ShowCaseDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ShowCase/")]
        public static ShowCaseDetailPage AttachShowCaseDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ShowCase/");
            return new ShowCaseDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ShowCaseDetailLayout> AttachShowCaseDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ShowCase']").Wait();

    }

}
