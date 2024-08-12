using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DriverTest1DetailLayout : ComponentBase
    {
        public GridDriver GridMainGrid => ByCssSelector("div[data-name='GridMain']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public NumberFieldDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public TextFieldDriver TextArea => ByCssSelector("div[data-name='TextArea']").Wait();
        public BooleanFieldDriver Check => ByCssSelector("div[data-name='Check']").Wait();
        public BooleanFieldDriver Switch => ByCssSelector("div[data-name='Switch']").Wait();
        public BooleanFieldDriver Toggle => ByCssSelector("div[data-name='Toggle']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public DateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public LabelFieldDriver Label => ByCssSelector("div[data-name='Label']").Wait();
        public TimeFieldDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public SelectFieldDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public SelectFieldDriver SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();
        public LinkFieldDriver<BlogOwnerListLayout, BlogOwnerSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public RadioButtonFieldDriver RadioButtonAAA => ByCssSelector("div[data-name='RadioButtonAAA']").Wait();
        public RadioButtonFieldDriver RadioButtonBBB => ByCssSelector("div[data-name='RadioButtonBBB']").Wait();
        public RadioButtonFieldDriver RadioButtonCCC => ByCssSelector("div[data-name='RadioButtonCCC']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public AnchorTagFieldDriver ATag => ByCssSelector("div[data-name='ATag']").Wait();
        public LabelFieldDriver ModuleSelectLabel => ByCssSelector("div[data-name='ModuleSelectLabel']").Wait();
        public ModuleSelectFieldDriver ModuleSelect => ByCssSelector("div[data-name='ModuleSelect']").Wait();
        public RadioGroupFieldDriver RadioGroup => ByCssSelector("div[data-name='RadioGroup']").Wait();
        public DetailListFieldDriver<DriverTest1ChildrenDetailLayout> Table => ByCssSelector("div[data-name='Table']").Wait();
        public ButtonFieldDriver Button => ByCssSelector("div[data-name='Button']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public DriverTest1DetailLayout(IWebElement element) : base(element) { }

        public static implicit operator DriverTest1DetailLayout(ElementFinder finder) => finder.Find<DriverTest1DetailLayout>();
    }

    public class DriverTest1DetailPage : DetailPage<DriverTest1DetailLayout>
    {

        public DriverTest1DetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class DriverTest1DetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/DriverTest1/")]
        public static DriverTest1DetailPage AttachDriverTest1DetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/DriverTest1/");
            return new DriverTest1DetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<DriverTest1DetailLayout> AttachDriverTest1Dialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='DriverTest1']").Wait();

    }

}
