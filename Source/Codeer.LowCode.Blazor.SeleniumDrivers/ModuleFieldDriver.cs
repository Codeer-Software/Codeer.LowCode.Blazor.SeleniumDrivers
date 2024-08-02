using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ModuleFieldDriver<TDetailLayout> : ComponentBase
        where TDetailLayout : ComponentBase
    {
        public TDetailLayout Module => (TDetailLayout)Activator.CreateInstance(typeof(TDetailLayout), Element)!;
        public ModuleFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ModuleFieldDriver<TDetailLayout>(ElementFinder finder) =>
            finder.Find<ModuleFieldDriver<TDetailLayout>>();
    }
}
