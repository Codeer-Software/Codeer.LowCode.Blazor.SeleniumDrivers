using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class RankSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver LabelRankName => ByCssSelector("div[data-name='LabelRankName']").Wait();
        public TextFieldSearchDriver RankName => ByCssSelector("div[data-name='RankName']").Wait();

        public RankSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator RankSearchLayout(ElementFinder finder) => finder.Find<RankSearchLayout>();
    }

}
