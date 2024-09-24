using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class SelectFieldDriver : ComponentBase
    {
        public WaitDropDownListDriver Select => ByTagName("select").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public SelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator SelectFieldDriver(ElementFinder finder) => finder.Find<SelectFieldDriver>();
    }

    public class SelectFieldSearchDriver : ComponentBase
    {
        public WaitDropDownListDriver Select => ByTagName("select").Wait();
        public ToggleButtonDriver IsNot => new ToggleButtonDriver(ByCssSelector(".input-group + div input[type='checkbox']").Wait().Find().GetParent());
        public ItemsControlDriver<SelectListItemDriver> MultipleSelect => ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<SelectListItemDriver>>();
        public SelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator SelectFieldSearchDriver(ElementFinder finder) => finder.Find<SelectFieldSearchDriver>();
    }

    public class WaitDropDownListDriver : DropDownListDriver
    {
        public WaitDropDownListDriver(IWebElement element) : base(element) { }
        public new void Edit(string text)
        {
            Element.Click();
            for (int i = 0; i < 10 && !Items.Any(e => e == text); i++)
            {
                Thread.Sleep(100);
            }
            base.Edit(text);
        }

        public new void Edit(int index)
        {
            for (int i = 0; i < 10 && Items.Length <= index; i++)
            {
                Thread.Sleep(100);
            }
            base.Edit(index);
        }
        public static implicit operator WaitDropDownListDriver(ElementFinder finder) => finder.Find<WaitDropDownListDriver>();
    }
}
