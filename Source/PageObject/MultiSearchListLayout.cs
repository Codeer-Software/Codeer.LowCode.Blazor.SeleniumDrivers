using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class MultiSearchListLayout : ListLayoutBase
    {
        public RadioGroupFieldDriver Radio => ByCssSelector("td[data-name='Radio']").Wait();
        public SelectFieldDriver Select => ByCssSelector("td[data-name='Select']").Wait();
        public SelectFieldDriver SelectLink => ByCssSelector("td[data-name='SelectLink']").Wait();

        public MultiSearchListLayout(IWebElement element) : base(element) { }

        public static implicit operator MultiSearchListLayout(ElementFinder finder) => finder.Find<MultiSearchListLayout>();
    }

    public class MultiSearchListPage : ListPage<MultiSearchListLayout, MultiSearchSearchLayout>
    {

        public MultiSearchListPage(IWebDriver driver) : base(driver) { }

    }

    public static class MultiSearchListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/MultiSearch")]
        public static MultiSearchListPage AttachMultiSearchListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/MultiSearch");
            return new MultiSearchListPage(driver);
        }

    }

}
