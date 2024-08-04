using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldTestListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver テキストフィールド => ByCssSelector("td[data-name='テキストフィールド']").Wait();

        public FieldTestListLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldTestListLayout(ElementFinder finder) => finder.Find<FieldTestListLayout>();
    }

    public class FieldTestListPage : ListPage<FieldTestListLayout, FieldTestSearchLayout>
    {

        public FieldTestListPage(IWebDriver driver) : base(driver) { }

    }

    public static class FieldTestListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/FieldTest")]
        public static FieldTestListPage AttachFieldTestListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/FieldTest");
            return new FieldTestListPage(driver);
        }

    }

}
