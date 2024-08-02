using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class TabDriver : ComponentBase
    {
        public ItemsControlDriver<TabItemDriver> Items =>
            ByTagName("ul").Wait().Find<ItemsControlDriver<TabItemDriver>>();
        public TabDriver(IWebElement element) : base(element) { }
        public static implicit operator TabDriver(ElementFinder finder) => finder.Find<TabDriver>();
    }

    public class TabItemDriver : ControlDriverBase
    {
        public bool IsActive => Element.GetAttribute("class").Contains("active");
        public TabItemDriver(IWebElement element) : base(element) { }
        public static implicit operator TabItemDriver(ElementFinder finder) => finder.Find<TabItemDriver>();

        public void Click() => Element.Click();

        [CaptureCodeGenerator]
        public string GetWebElementCaptureGenerator()
        {
            return $@"
                    element.addEventListener('click', function() {{ 
                      var name = __codeerTestAssistantPro.getElementName(this);
                      __codeerTestAssistantPro.pushCode(name + '.Click();');
                    }}, false);";
        }
    }
}
