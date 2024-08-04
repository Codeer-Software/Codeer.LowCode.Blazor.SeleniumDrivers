using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TransportationListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public SelectFieldDriver Select交通手段名 => ByCssSelector("td[data-name='Select交通手段名']").Wait();
        public TimeFieldDriver Time出発日時 => ByCssSelector("td[data-name='Time出発日時']").Wait();
        public AnchorTagFieldDriver AnchorTag => ByCssSelector("td[data-name='AnchorTag']").Wait();

        public TransportationListLayout(IWebElement element) : base(element) { }

        public static implicit operator TransportationListLayout(ElementFinder finder) => finder.Find<TransportationListLayout>();
    }

    public class TransportationListPage : ListPage<TransportationListLayout, TransportationSearchLayout>
    {

        public TransportationListPage(IWebDriver driver) : base(driver) { }

    }

    public static class TransportationListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Transportation")]
        public static TransportationListPage AttachTransportationListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Transportation");
            return new TransportationListPage(driver);
        }

    }

}
