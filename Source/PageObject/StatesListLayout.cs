using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class StatesListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();
        public TextFieldDriver AbbreviationName => ByCssSelector("td[data-name='AbbreviationName']").Wait();
        public BooleanFieldDriver Original => ByCssSelector("td[data-name='Original']").Wait();
        public DateFieldDriver EstablishmentDate => ByCssSelector("td[data-name='EstablishmentDate']").Wait();
        public NumberFieldDriver Population => ByCssSelector("td[data-name='Population']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("td[data-name='DateTime']").Wait();
        public TimeFieldDriver Time => ByCssSelector("td[data-name='Time']").Wait();

        public StatesListLayout(IWebElement element) : base(element) { }

        public static implicit operator StatesListLayout(ElementFinder finder) => finder.Find<StatesListLayout>();
    }

    public class StatesListPage : ListPage<StatesListLayout, StatesSearchLayout>
    {

        public StatesListPage(IWebDriver driver) : base(driver) { }

    }

    public static class StatesListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/States")]
        public static StatesListPage AttachStatesListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/States");
            return new StatesListPage(driver);
        }

    }

}
