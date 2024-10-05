using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class ConditionDataDetailLayout : ComponentBase
    {
        public TextFieldDriver A => ByCssSelector("div[data-name='A']").Wait();
        public TextFieldDriver B => ByCssSelector("div[data-name='B']").Wait();
        public TextFieldDriver C => ByCssSelector("div[data-name='C']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public ConditionDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ConditionDataDetailLayout(ElementFinder finder) => finder.Find<ConditionDataDetailLayout>();
    }

    public class ConditionDataDetailPage : DetailPage<ConditionDataDetailLayout>
    {

        public ConditionDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ConditionDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ConditionData/")]
        public static ConditionDataDetailPage AttachConditionDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ConditionData/");
            return new ConditionDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ConditionDataDetailLayout> AttachConditionDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ConditionData']").Wait();

    }

}
