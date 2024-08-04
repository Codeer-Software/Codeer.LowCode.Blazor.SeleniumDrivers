using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class PrefectureSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver Label地域名 => ByCssSelector("div[data-name='Label地域名']").Wait();
        public SelectFieldSearchDriver District => ByCssSelector("div[data-name='District']").Wait();
        public LabelFieldSearchDriver Label都道府県名 => ByCssSelector("div[data-name='Label都道府県名']").Wait();
        public TextFieldSearchDriver Name => ByCssSelector("div[data-name='Name']").Wait();

        public PrefectureSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator PrefectureSearchLayout(ElementFinder finder) => finder.Find<PrefectureSearchLayout>();
    }

    public class PrefectureSearchLayout_地域検索 : ComponentBase
    {
        public SearchGridDriver SearchGridLayout1Grid => ByCssSelector("div[data-name='SearchGridLayout1']").Wait();
        public LabelFieldSearchDriver Label地域名 => ByCssSelector("div[data-name='Label地域名']").Wait();
        public SelectFieldSearchDriver District => ByCssSelector("div[data-name='District']").Wait();

        public PrefectureSearchLayout_地域検索(IWebElement element) : base(element) { }

        public static implicit operator PrefectureSearchLayout_地域検索(ElementFinder finder) => finder.Find<PrefectureSearchLayout_地域検索>();
    }

    public class PrefectureSearchLayout_都道府県名検索 : ComponentBase
    {
        public SearchGridDriver SearchGridLayout2Grid => ByCssSelector("div[data-name='SearchGridLayout2']").Wait();
        public LabelFieldSearchDriver Label都道府県名 => ByCssSelector("div[data-name='Label都道府県名']").Wait();
        public TextFieldSearchDriver Name => ByCssSelector("div[data-name='Name']").Wait();

        public PrefectureSearchLayout_都道府県名検索(IWebElement element) : base(element) { }

        public static implicit operator PrefectureSearchLayout_都道府県名検索(ElementFinder finder) => finder.Find<PrefectureSearchLayout_都道府県名検索>();
    }

}
