using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TeaListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver 名前 => ByCssSelector("td[data-name='名前']").Wait();
        public TextFieldDriver 説明 => ByCssSelector("td[data-name='説明']").Wait();

        public TeaListLayout(IWebElement element) : base(element) { }

        public static implicit operator TeaListLayout(ElementFinder finder) => finder.Find<TeaListLayout>();
    }

    public class TeaListPage : ListPage<TeaListLayout, TeaSearchLayout>
    {

        public TeaListPage(IWebDriver driver) : base(driver) { }

    }

    public static class TeaListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Tea")]
        public static TeaListPage AttachTeaListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Tea");
            return new TeaListPage(driver);
        }

    }

}
