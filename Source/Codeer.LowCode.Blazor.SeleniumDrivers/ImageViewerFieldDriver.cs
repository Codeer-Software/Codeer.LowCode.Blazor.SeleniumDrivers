using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ImageViewerFieldDriver : ComponentBase
    {
        public IWebElement Image => ByTagName("img").Wait().Find();
        public ImageViewerFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator ImageViewerFieldDriver(ElementFinder finder) => finder.Find<ImageViewerFieldDriver>();
    }
}
