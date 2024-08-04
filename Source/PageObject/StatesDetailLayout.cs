using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class StatesDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelState => ByCssSelector("div[data-name='LabelState']").Wait();
        public LabelFieldDriver Label名前 => ByCssSelector("div[data-name='Label名前']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver Label略称 => ByCssSelector("div[data-name='Label略称']").Wait();
        public TextFieldDriver AbbreviationName => ByCssSelector("div[data-name='AbbreviationName']").Wait();
        public LabelFieldDriver Labelオリジナル => ByCssSelector("div[data-name='Labelオリジナル']").Wait();
        public BooleanFieldDriver Original => ByCssSelector("div[data-name='Original']").Wait();
        public LabelFieldDriver Label設立日 => ByCssSelector("div[data-name='Label設立日']").Wait();
        public DateFieldDriver EstablishmentDate => ByCssSelector("div[data-name='EstablishmentDate']").Wait();
        public LabelFieldDriver Label人口 => ByCssSelector("div[data-name='Label人口']").Wait();
        public NumberFieldDriver Population => ByCssSelector("div[data-name='Population']").Wait();
        public LabelFieldDriver Label旗 => ByCssSelector("div[data-name='Label旗']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public LabelFieldDriver Label日時 => ByCssSelector("div[data-name='Label日時']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public LabelFieldDriver Label時刻 => ByCssSelector("div[data-name='Label時刻']").Wait();
        public TimeFieldDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public SubmitButtonFieldDriver SubmitButton登録更新 => ByCssSelector("div[data-name='SubmitButton登録更新']").Wait();

        public StatesDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator StatesDetailLayout(ElementFinder finder) => finder.Find<StatesDetailLayout>();
    }

    public class StatesDetailPage : DetailPage<StatesDetailLayout>
    {

        public StatesDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class StatesDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/States/")]
        public static StatesDetailPage AttachStatesDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/States/");
            return new StatesDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<StatesDetailLayout> AttachStatesDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='States']").Wait();

    }

}
