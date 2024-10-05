using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ConditionDataListLayout : ListLayoutBase
    {
        public TextFieldDriver A => ByCssSelector("td[data-name='A']").Wait();
        public TextFieldDriver B => ByCssSelector("td[data-name='B']").Wait();
        public TextFieldDriver C => ByCssSelector("td[data-name='C']").Wait();

        public ConditionDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator ConditionDataListLayout(ElementFinder finder) => finder.Find<ConditionDataListLayout>();
    }

    public class ConditionDataListPage : ListPage<ConditionDataListLayout, ConditionDataSearchLayout>
    {

        public ConditionDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ConditionDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ConditionData")]
        public static ConditionDataListPage AttachConditionDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ConditionData");
            return new ConditionDataListPage(driver);
        }

    }

}
