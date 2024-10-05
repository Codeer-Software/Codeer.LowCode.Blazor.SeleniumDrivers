using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class MultiSearchSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver RadioLabel => ByCssSelector("div[data-name='RadioLabel']").Wait();
        public RadioGroupFieldSearchDriver Radio => ByCssSelector("div[data-name='Radio']").Wait();
        public LabelFieldSearchDriver SelectLabel => ByCssSelector("div[data-name='SelectLabel']").Wait();
        public SelectFieldSearchDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public LabelFieldSearchDriver SelectLinkLabel => ByCssSelector("div[data-name='SelectLinkLabel']").Wait();
        public SelectFieldSearchDriver SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();

        public MultiSearchSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator MultiSearchSearchLayout(ElementFinder finder) => finder.Find<MultiSearchSearchLayout>();
    }

}
