using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DriverTest1SearchLayout : ComponentBase
    {
        public LabelFieldSearchDriver Text_Label => ByCssSelector("div[data-name='Text_Label']").Wait();
        public TextFieldSearchDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public TextFieldSearchDriver TextArea => ByCssSelector("div[data-name='TextArea']").Wait();
        public NumberFieldSearchDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public LinkFieldSearchDriver<BlogOwnerListLayout, BlogOwnerSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public BooleanFieldSearchDriver Check => ByCssSelector("div[data-name='Check']").Wait();
        public BooleanFieldSearchDriver Switch => ByCssSelector("div[data-name='Switch']").Wait();
        public LabelFieldSearchDriver ToggleLabel => ByCssSelector("div[data-name='ToggleLabel']").Wait();
        public BooleanFieldSearchDriver Toggle => ByCssSelector("div[data-name='Toggle']").Wait();
        public DateTimeFieldSearchDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public DateFieldSearchDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public TimeFieldSearchDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public SelectFieldSearchDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public LabelFieldSearchDriver SelectLinkLabel => ByCssSelector("div[data-name='SelectLinkLabel']").Wait();
        public SelectFieldSearchDriver SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();
        public FileFieldSearchDriver File => ByCssSelector("div[data-name='File']").Wait();
        public LabelFieldSearchDriver ModuleSelectLabel => ByCssSelector("div[data-name='ModuleSelectLabel']").Wait();
        public ModuleSelectFieldSearchDriver ModuleSelect => ByCssSelector("div[data-name='ModuleSelect']").Wait();
        public LabelFieldSearchDriver RadioGroupLabel => ByCssSelector("div[data-name='RadioGroupLabel']").Wait();
        public RadioGroupFieldSearchDriver RadioGroup => ByCssSelector("div[data-name='RadioGroup']").Wait();

        public DriverTest1SearchLayout(IWebElement element) : base(element) { }

        public static implicit operator DriverTest1SearchLayout(ElementFinder finder) => finder.Find<DriverTest1SearchLayout>();
    }

}
