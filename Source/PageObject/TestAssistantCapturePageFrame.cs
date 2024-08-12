using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TestAssistantCaptureLeft : ComponentBase
    {
        public AnchorDriver DriverTest1 => ByCssSelector("[data-title='DriverTest1']").Wait();

        public TestAssistantCaptureLeft(IWebElement element) : base(element) { }

        public static implicit operator TestAssistantCaptureLeft(ElementFinder finder) => finder.Find<TestAssistantCaptureLeft>();
    }

    public static class TestAssistantCaptureLeftExtensions
    {

        [ComponentObjectIdentify]
        public static TestAssistantCaptureLeft AttachTestAssistantCaptureLeft(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='sidebar'][data-system-placement='left']").Wait();

    }

    public class TestAssistantCaptureRight : ComponentBase
    {
        public AnchorDriver B => ByCssSelector("[data-title='B']").Wait();

        public TestAssistantCaptureRight(IWebElement element) : base(element) { }

        public static implicit operator TestAssistantCaptureRight(ElementFinder finder) => finder.Find<TestAssistantCaptureRight>();
    }

    public static class TestAssistantCaptureRightExtensions
    {

        [ComponentObjectIdentify]
        public static TestAssistantCaptureRight AttachTestAssistantCaptureRight(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='sidebar'][data-system-placement='right']").Wait();

    }

    public class TestAssistantCaptureHeader : ComponentBase
    {
        public AnchorDriver B => ByCssSelector("[data-title='B']").Wait();

        public TestAssistantCaptureHeader(IWebElement element) : base(element) { }

        public static implicit operator TestAssistantCaptureHeader(ElementFinder finder) => finder.Find<TestAssistantCaptureHeader>();
    }

    public static class TestAssistantCaptureHeaderExtensions
    {

        [ComponentObjectIdentify]
        public static TestAssistantCaptureHeader AttachTestAssistantCaptureHeader(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='topbar']").Wait();

    }

}
