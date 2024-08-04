using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class StatesSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver Label名前 => ByCssSelector("div[data-name='Label名前']").Wait();
        public TextFieldSearchDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldSearchDriver Label略称 => ByCssSelector("div[data-name='Label略称']").Wait();
        public TextFieldSearchDriver AbbreviationName => ByCssSelector("div[data-name='AbbreviationName']").Wait();
        public LabelFieldSearchDriver Labelオリジナル => ByCssSelector("div[data-name='Labelオリジナル']").Wait();
        public BooleanFieldSearchDriver Original => ByCssSelector("div[data-name='Original']").Wait();
        public LabelFieldSearchDriver Label設立日 => ByCssSelector("div[data-name='Label設立日']").Wait();
        public DateFieldSearchDriver EstablishmentDate => ByCssSelector("div[data-name='EstablishmentDate']").Wait();
        public LabelFieldSearchDriver Label人口 => ByCssSelector("div[data-name='Label人口']").Wait();
        public NumberFieldSearchDriver Population => ByCssSelector("div[data-name='Population']").Wait();
        public LabelFieldSearchDriver Label旗 => ByCssSelector("div[data-name='Label旗']").Wait();
        public TextFieldSearchDriver FlagImageName => ByCssSelector("div[data-name='FlagImageName']").Wait();
        public LabelFieldSearchDriver Label日時 => ByCssSelector("div[data-name='Label日時']").Wait();
        public DateTimeFieldSearchDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public LabelFieldSearchDriver Label時刻 => ByCssSelector("div[data-name='Label時刻']").Wait();
        public TimeFieldSearchDriver Time => ByCssSelector("div[data-name='Time']").Wait();

        public StatesSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator StatesSearchLayout(ElementFinder finder) => finder.Find<StatesSearchLayout>();
    }

}
