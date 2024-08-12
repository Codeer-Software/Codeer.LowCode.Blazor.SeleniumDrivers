using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class DriverTest1ChildrenDetailLayout : ComponentBase
    {
        public TextFieldDriver A => ByCssSelector("div[data-name='A']").Wait();
        public TextFieldDriver B => ByCssSelector("div[data-name='B']").Wait();
        public TextFieldDriver C => ByCssSelector("div[data-name='C']").Wait();

        public DriverTest1ChildrenDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator DriverTest1ChildrenDetailLayout(ElementFinder finder) => finder.Find<DriverTest1ChildrenDetailLayout>();
    }

    public class DriverTest1ChildrenDetailPage : DetailPage<DriverTest1ChildrenDetailLayout>
    {

        public DriverTest1ChildrenDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class DriverTest1ChildrenDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/DriverTest1Children/")]
        public static DriverTest1ChildrenDetailPage AttachDriverTest1ChildrenDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/DriverTest1Children/");
            return new DriverTest1ChildrenDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<DriverTest1ChildrenDetailLayout> AttachDriverTest1ChildrenDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='DriverTest1Children']").Wait();

    }

}
