using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DriverTest1ChildrenListLayout : ListLayoutBase
    {
        public TextFieldDriver A => ByCssSelector("td[data-name='A']").Wait();
        public TextFieldDriver B => ByCssSelector("td[data-name='B']").Wait();
        public TextFieldDriver C => ByCssSelector("td[data-name='C']").Wait();

        public DriverTest1ChildrenListLayout(IWebElement element) : base(element) { }

        public static implicit operator DriverTest1ChildrenListLayout(ElementFinder finder) => finder.Find<DriverTest1ChildrenListLayout>();
    }

    public class DriverTest1ChildrenListPage : ListPage<DriverTest1ChildrenListLayout, DriverTest1ChildrenSearchLayout>
    {

        public DriverTest1ChildrenListPage(IWebDriver driver) : base(driver) { }

    }

    public static class DriverTest1ChildrenListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/DriverTest1Children")]
        public static DriverTest1ChildrenListPage AttachDriverTest1ChildrenListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/DriverTest1Children");
            return new DriverTest1ChildrenListPage(driver);
        }

    }

}
