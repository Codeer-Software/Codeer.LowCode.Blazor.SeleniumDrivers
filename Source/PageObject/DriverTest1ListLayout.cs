using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DriverTest1ListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Text => ByCssSelector("td[data-name='Text']").Wait();
        public BooleanFieldDriver Check => ByCssSelector("td[data-name='Check']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("td[data-name='DateTime']").Wait();
        public DateFieldDriver Date => ByCssSelector("td[data-name='Date']").Wait();
        public TimeFieldDriver Time => ByCssSelector("td[data-name='Time']").Wait();
        public LinkFieldDriver<BlogOwnerListLayout, BlogOwnerSearchLayout> Link => ByCssSelector("td[data-name='Link']").Wait();
        public BooleanFieldDriver Switch => ByCssSelector("td[data-name='Switch']").Wait();
        public BooleanFieldDriver Toggle => ByCssSelector("td[data-name='Toggle']").Wait();
        public TextFieldDriver TextArea => ByCssSelector("td[data-name='TextArea']").Wait();
        public FileFieldDriver File => ByCssSelector("td[data-name='File']").Wait();
        public SelectFieldDriver SelectLink => ByCssSelector("td[data-name='SelectLink']").Wait();
        public NumberFieldDriver Number => ByCssSelector("td[data-name='Number']").Wait();
        public RadioGroupFieldDriver RadioGroup => ByCssSelector("td[data-name='RadioGroup']").Wait();

        public DriverTest1ListLayout(IWebElement element) : base(element) { }

        public static implicit operator DriverTest1ListLayout(ElementFinder finder) => finder.Find<DriverTest1ListLayout>();
    }

    public class DriverTest1ListPage : ListPage<DriverTest1ListLayout, DriverTest1SearchLayout>
    {

        public DriverTest1ListPage(IWebDriver driver) : base(driver) { }

    }

    public static class DriverTest1ListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/DriverTest1")]
        public static DriverTest1ListPage AttachDriverTest1ListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/DriverTest1");
            return new DriverTest1ListPage(driver);
        }

    }

}
