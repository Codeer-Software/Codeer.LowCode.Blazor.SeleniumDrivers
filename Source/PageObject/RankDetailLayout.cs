using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class RankDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelId => ByCssSelector("div[data-name='LabelId']").Wait();
        public IdFieldDriver Id => ByCssSelector("div[data-name='Id']").Wait();
        public LabelFieldDriver LabelRankName => ByCssSelector("div[data-name='LabelRankName']").Wait();
        public TextFieldDriver RankName => ByCssSelector("div[data-name='RankName']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public RankDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator RankDetailLayout(ElementFinder finder) => finder.Find<RankDetailLayout>();
    }

    public class RankDetailLayout_Layout表示 : ComponentBase
    {
        public TextFieldDriver RankName => ByCssSelector("div[data-name='RankName']").Wait();

        public RankDetailLayout_Layout表示(IWebElement element) : base(element) { }

        public static implicit operator RankDetailLayout_Layout表示(ElementFinder finder) => finder.Find<RankDetailLayout_Layout表示>();
    }

    public class RankDetailPage : DetailPage<RankDetailLayout>
    {

        public RankDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class RankDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/Rank/")]
        public static RankDetailPage AttachRankDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/Rank/");
            return new RankDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<RankDetailLayout> AttachRankDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Rank']").Wait();

    }

}
