using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class BooleanFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public BooleanFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator BooleanFieldSearchDriver(ElementFinder finder) => finder.Find<BooleanFieldSearchDriver>();
    }

    public class DateFieldSearchDriver : ComponentBase
    {
        public DateDriver StartDate => ByCssSelector("input[data-search-target='min']").Wait();
        public DateDriver EndDate => ByCssSelector("input[data-search-target='max']").Wait();
        public DateFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator DateFieldSearchDriver(ElementFinder finder) => finder.Find<DateFieldSearchDriver>();
    }

    public class DateTimeFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver StartDate => ByCssSelector("input[data-search-target='min']").Wait();
        public TextBoxDriver EndDate => ByCssSelector("input[data-search-target='max']").Wait();
        public DateTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator DateTimeFieldSearchDriver(ElementFinder finder) => finder.Find<DateTimeFieldSearchDriver>();
    }

    public class FileFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver FileName => ByCssSelector("input[data-search-target='filename']").Wait();
        public DropDownListDriver FileNameMatch => ByCssSelector("select[data-search-target='filenamematch']").Wait();
        public TextBoxDriver MinFileSize => ByCssSelector("input[data-search-target='min']").Wait();
        public TextBoxDriver MaxFileSize => ByCssSelector("input[data-search-target='max']").Wait();
        public FileFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator FileFieldSearchDriver(ElementFinder finder) => finder.Find<FileFieldSearchDriver>();
    }

    public class LinkFieldSearchDriver<TListLayout, TSearchLayout>  : ComponentBase 
        where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait();
        public ButtonDriver Clear => ByCssSelector("button.btn-close").Wait();
        public ButtonDriver Search => ByCssSelector("button:has(.bi-search)").Wait();
        public SearchFieldDriver<TSearchLayout> LinkSearch => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> LinkList => ByCssSelector("div[data-system='list-field']").Wait();
        public LinkFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator LinkFieldSearchDriver<TListLayout, TSearchLayout>(ElementFinder finder) => finder.Find<LinkFieldSearchDriver<TListLayout, TSearchLayout>>();
    }

    public class ListFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public ListFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator ListFieldSearchDriver(ElementFinder finder) => finder.Find<ListFieldSearchDriver>();
    }

    public class ModuleSelectFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public ModuleSelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator ModuleSelectFieldSearchDriver(ElementFinder finder) => finder.Find<ModuleSelectFieldSearchDriver>();
    }

    public class NumberFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Min => ByCssSelector("input[data-search-target='min']").Wait();
        public TextBoxDriver Max => ByCssSelector("input[data-search-target='max']").Wait();
        public NumberFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator NumberFieldSearchDriver(ElementFinder finder) => finder.Find<NumberFieldSearchDriver>();
    }

    public class RadioGroupFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public CheckBoxDriver IsInverted => ByCssSelector(".input-group + div input[type='checkbox']").Wait();
        public ItemsControlDriver<SelectListItemDriver> MultipleSelect => ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<SelectListItemDriver>>();
        public RadioGroupFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadioGroupFieldSearchDriver(ElementFinder finder) => finder.Find<RadioGroupFieldSearchDriver>();
    }

    public class SelectFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public CheckBoxDriver IsInverted => ByCssSelector(".input-group + div input[type='checkbox']").Wait();
        public ItemsControlDriver<SelectListItemDriver> MultipleSelect => ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<SelectListItemDriver>>();
        public SelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator SelectFieldSearchDriver(ElementFinder finder) => finder.Find<SelectFieldSearchDriver>();
    }

    public class SelectListItemDriver : ComponentBase
    {
        public IWebElement Text => ByTagName("label").Wait().Find();
        public CheckBoxDriver CheckBox => ByTagName("input").Wait();
        public SelectListItemDriver(IWebElement element) : base(element) { }
        public static implicit operator SelectListItemDriver(ElementFinder finder) => finder.Find<SelectListItemDriver>();
    }

    public class TextFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait();
        public DropDownListDriver Match => ByTagName("select").Wait();
        public TextFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator TextFieldSearchDriver(ElementFinder finder) => finder.Find<TextFieldSearchDriver>();
    }

    public class TimeFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver StartTime => ByCssSelector("input[data-search-target='min']").Wait();
        public TextBoxDriver EndTime => ByCssSelector("input[data-search-target='max']").Wait();
        public TimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator TimeFieldSearchDriver(ElementFinder finder) => finder.Find<TimeFieldSearchDriver>();
    }

    public class LabelFieldSearchDriver : ComponentBase
    {
        public IWebElement Label => ByTagName("label").Wait().Find();
        public LabelFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator LabelFieldSearchDriver(ElementFinder finder) => finder.Find<LabelFieldSearchDriver>();
    }
}
