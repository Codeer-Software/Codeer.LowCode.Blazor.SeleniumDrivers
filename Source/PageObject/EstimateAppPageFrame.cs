using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class EstimateAppLeft : ComponentBase
    {
        public AnchorDriver マスタ => ByCssSelector("[data-title='マスタ']").Wait();
        public AnchorDriver マスタ_顧客 => ByCssSelector("[data-title='マスタ/顧客']").Wait();
        public AnchorDriver マスタ_担当者 => ByCssSelector("[data-title='マスタ/担当者']").Wait();
        public AnchorDriver 見積 => ByCssSelector("[data-title='見積']").Wait();

        public EstimateAppLeft(IWebElement element) : base(element) { }

        public static implicit operator EstimateAppLeft(ElementFinder finder) => finder.Find<EstimateAppLeft>();
    }

    public static class EstimateAppLeftExtensions
    {

        [ComponentObjectIdentify]
        public static EstimateAppLeft AttachEstimateAppLeft(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='sidebar'][data-system-placement='left']").Wait();

    }

}
