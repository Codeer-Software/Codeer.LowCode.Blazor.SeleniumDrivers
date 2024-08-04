using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class MainLeft : ComponentBase
    {
        public AnchorDriver Trip => ByCssSelector("[data-title='Trip']").Wait();
        public AnchorDriver Trip_Plans => ByCssSelector("[data-title='Trip/Plans']").Wait();
        public AnchorDriver 州 => ByCssSelector("[data-title='州']").Wait();
        public AnchorDriver Showcase => ByCssSelector("[data-title='Showcase']").Wait();
        public AnchorDriver ユーザー => ByCssSelector("[data-title='ユーザー']").Wait();
        public AnchorDriver Blog => ByCssSelector("[data-title='Blog']").Wait();
        public AnchorDriver 投稿 => ByCssSelector("[data-title='投稿']").Wait();
        public AnchorDriver フィールドテスト => ByCssSelector("[data-title='フィールドテスト']").Wait();
        public AnchorDriver 部署 => ByCssSelector("[data-title='部署']").Wait();
        public AnchorDriver 所属_配属 => ByCssSelector("[data-title='所属・配属']").Wait();
        public AnchorDriver EstimateClientCompany => ByCssSelector("[data-title='EstimateClientCompany']").Wait();
        public AnchorDriver EstimateContactPerson => ByCssSelector("[data-title='EstimateContactPerson']").Wait();
        public AnchorDriver Estimate => ByCssSelector("[data-title='Estimate']").Wait();
        public AnchorDriver EstimateDetail => ByCssSelector("[data-title='EstimateDetail']").Wait();

        public MainLeft(IWebElement element) : base(element) { }

        public static implicit operator MainLeft(ElementFinder finder) => finder.Find<MainLeft>();
    }

    public static class MainLeftExtensions
    {

        [ComponentObjectIdentify]
        public static MainLeft AttachMainLeft(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='sidebar'][data-system-placement='left']").Wait();

    }

    public class MainRight : ComponentBase
    {
        public AnchorDriver Showcase => ByCssSelector("[data-title='Showcase']").Wait();
        public AnchorDriver Prefecture => ByCssSelector("[data-title='Prefecture']").Wait();
        public AnchorDriver ランク => ByCssSelector("[data-title='ランク']").Wait();
        public AnchorDriver 紅茶 => ByCssSelector("[data-title='紅茶']").Wait();
        public AnchorDriver ShopOrder => ByCssSelector("[data-title='ShopOrder']").Wait();

        public MainRight(IWebElement element) : base(element) { }

        public static implicit operator MainRight(ElementFinder finder) => finder.Find<MainRight>();
    }

    public static class MainRightExtensions
    {

        [ComponentObjectIdentify]
        public static MainRight AttachMainRight(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='sidebar'][data-system-placement='right']").Wait();

    }

}
