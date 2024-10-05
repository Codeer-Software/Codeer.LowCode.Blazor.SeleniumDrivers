using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition3DetailLayout : ComponentBase
    {
        public LabelFieldDriver Label => ByCssSelector("div[data-name='Label']").Wait();
        public LabelFieldDriver LinkLabel => ByCssSelector("div[data-name='LinkLabel']").Wait();
        public LinkFieldDriver<ConditionDataListLayout, ConditionDataSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();

        public FieldSearchCondition3DetailLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition3DetailLayout(ElementFinder finder) => finder.Find<FieldSearchCondition3DetailLayout>();
    }

    public class FieldSearchCondition3DetailPage : DetailPage<FieldSearchCondition3DetailLayout>
    {

        public FieldSearchCondition3DetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class FieldSearchCondition3DetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/FieldSearchCondition3")]
        public static FieldSearchCondition3DetailPage AttachFieldSearchCondition3DetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/FieldSearchCondition3");
            return new FieldSearchCondition3DetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<FieldSearchCondition3DetailLayout> AttachFieldSearchCondition3Dialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='FieldSearchCondition3']").Wait();

    }

}
