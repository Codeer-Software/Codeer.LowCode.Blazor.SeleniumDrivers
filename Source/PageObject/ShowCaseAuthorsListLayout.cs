using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ShowCaseAuthorsListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Email => ByCssSelector("td[data-name='Email']").Wait();
        public TextFieldDriver Username => ByCssSelector("td[data-name='Username']").Wait();

        public ShowCaseAuthorsListLayout(IWebElement element) : base(element) { }

        public static implicit operator ShowCaseAuthorsListLayout(ElementFinder finder) => finder.Find<ShowCaseAuthorsListLayout>();
    }

    public class ShowCaseAuthorsListPage : ListPage<ShowCaseAuthorsListLayout, ShowCaseAuthorsSearchLayout>
    {

        public ShowCaseAuthorsListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ShowCaseAuthorsListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ShowCaseAuthors")]
        public static ShowCaseAuthorsListPage AttachShowCaseAuthorsListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ShowCaseAuthors");
            return new ShowCaseAuthorsListPage(driver);
        }

    }

}
