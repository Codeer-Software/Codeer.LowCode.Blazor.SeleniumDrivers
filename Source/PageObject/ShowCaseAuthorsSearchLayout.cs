using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ShowCaseAuthorsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver LabelEメール => ByCssSelector("div[data-name='LabelEメール']").Wait();
        public TextFieldSearchDriver Email => ByCssSelector("div[data-name='Email']").Wait();
        public LabelFieldSearchDriver Labelユーザー名 => ByCssSelector("div[data-name='Labelユーザー名']").Wait();
        public TextFieldSearchDriver Username => ByCssSelector("div[data-name='Username']").Wait();

        public ShowCaseAuthorsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ShowCaseAuthorsSearchLayout(ElementFinder finder) => finder.Find<ShowCaseAuthorsSearchLayout>();
    }

}
