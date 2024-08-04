using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ShowCaseListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public AnchorTagFieldDriver AnchorTag => ByCssSelector("td[data-name='AnchorTag']").Wait();
        public DateFieldDriver Date日付 => ByCssSelector("td[data-name='Date日付']").Wait();
        public DateTimeFieldDriver DateTime日時 => ByCssSelector("td[data-name='DateTime日時']").Wait();
        public BooleanFieldDriver BooleanCheckBox => ByCssSelector("td[data-name='BooleanCheckBox']").Wait();
        public BooleanFieldDriver BooleanSwitch => ByCssSelector("td[data-name='BooleanSwitch']").Wait();
        public BooleanFieldDriver BooleanToggle => ByCssSelector("td[data-name='BooleanToggle']").Wait();
        public TextFieldDriver Text => ByCssSelector("td[data-name='Text']").Wait();

        public ShowCaseListLayout(IWebElement element) : base(element) { }

        public static implicit operator ShowCaseListLayout(ElementFinder finder) => finder.Find<ShowCaseListLayout>();
    }

    public class ShowCaseListLayout_一覧 : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();

        public ShowCaseListLayout_一覧(IWebElement element) : base(element) { }

        public static implicit operator ShowCaseListLayout_一覧(ElementFinder finder) => finder.Find<ShowCaseListLayout_一覧>();
    }

    public class ShowCaseListPage : ListPage<ShowCaseListLayout, ShowCaseSearchLayout>
    {

        public ShowCaseListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ShowCaseListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ShowCase")]
        public static ShowCaseListPage AttachShowCaseListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ShowCase");
            return new ShowCaseListPage(driver);
        }

    }

}
