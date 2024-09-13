using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class MainLeft : ComponentBase
    {
        public AnchorDriver Home => ByCssSelector(".navbar-brand").Wait();
        public AnchorDriver ReadDataControls => ByCssSelector("[data-title='ReadDataControls']").Wait();
        public AnchorDriver WriteDataControls => ByCssSelector("[data-title='WriteDataControls']").Wait();
        public AnchorDriver LinkData => ByCssSelector("[data-title='LinkData']").Wait();
        public AnchorDriver ReadListData => ByCssSelector("[data-title='ReadListData']").Wait();
        public AnchorDriver ReadListDataControls => ByCssSelector("[data-title='ReadListDataControls']").Wait();
        public AnchorDriver WriteListData => ByCssSelector("[data-title='WriteListData']").Wait();
        public AnchorDriver ReadDetailListData => ByCssSelector("[data-title='ReadDetailListData']").Wait();
        public AnchorDriver WriteDetailListData => ByCssSelector("[data-title='WriteDetailListData']").Wait();
        public AnchorDriver ReadTileListData => ByCssSelector("[data-title='ReadTileListData']").Wait();
        public AnchorDriver WriteTileListData => ByCssSelector("[data-title='WriteTileListData']").Wait();

        public MainLeft(IWebElement element) : base(element) { }

        public static implicit operator MainLeft(ElementFinder finder) => finder.Find<MainLeft>();
    }

    public static class MainLeftExtensions
    {

        [ComponentObjectIdentify]
        public static MainLeft AttachMainLeft(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='sidebar'][data-system-placement='left']").Wait();

    }

}
