using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class MessageBoxDriver : ComponentBase
    {
        public IWebElement Body => ByCssSelector(".modal-body").Wait().Find();
        public ItemsControlDriver<ButtonDriver> Buttons => ByCssSelector(".modal-footer").Wait().Find<ItemsControlDriver<ButtonDriver>>();
        public ButtonDriver CloseButton => ByCssSelector("button.btn-close").Wait();
        public MessageBoxDriver(IWebElement element) : base(element) { }
        public static implicit operator MessageBoxDriver(ElementFinder finder) => finder.Find<MessageBoxDriver>();
    }

    public static class MessageBoxExtension
    {
        [ComponentObjectIdentify]
        public static MessageBoxDriver AttachMessageBox(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector(".modal.show[data-system='message-box']").Wait();

    }
}
