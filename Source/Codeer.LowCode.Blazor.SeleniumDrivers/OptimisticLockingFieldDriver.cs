using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class OptimisticLockingFieldDriver : ComponentBase
    {
        public IWebElement Value => ByTagName("span").Wait().Find();
        public OptimisticLockingFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator OptimisticLockingFieldDriver(ElementFinder finder) =>
            finder.Find<OptimisticLockingFieldDriver>();
    }
}
