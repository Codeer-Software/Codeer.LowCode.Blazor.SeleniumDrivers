using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TagSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public TextFieldSearchDriver TagText => ByCssSelector("div[data-name='TagText']").Wait();
        public LabelFieldSearchDriver Label => ByCssSelector("div[data-name='Label']").Wait();

        public TagSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator TagSearchLayout(ElementFinder finder) => finder.Find<TagSearchLayout>();
    }

}
