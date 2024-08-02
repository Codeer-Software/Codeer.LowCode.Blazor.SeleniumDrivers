using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ModuleDialogDriver<TDetailLayout> : ComponentBase where TDetailLayout : ComponentBase
    {
        public TDetailLayout DetailLayout => ByCssSelector(".modal-body").Wait().Find<TDetailLayout>();
        public ItemsControlDriver<ButtonDriver> Buttons => ByCssSelector(".modal-footer").Wait().Find<ItemsControlDriver<ButtonDriver>>();
        public ButtonDriver CloseButton => ByCssSelector("button.btn-close").Wait();
        public ModuleDialogDriver(IWebElement element) : base(element) { }
        public static implicit operator ModuleDialogDriver<TDetailLayout>(ElementFinder finder) => finder.Find<ModuleDialogDriver<TDetailLayout>>();
    }
}
