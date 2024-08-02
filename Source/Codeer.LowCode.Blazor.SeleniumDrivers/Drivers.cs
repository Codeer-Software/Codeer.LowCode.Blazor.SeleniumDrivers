using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class BooleanFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public BooleanFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator BooleanFieldSearchDriver(ElementFinder finder) =>
            finder.Find<BooleanFieldSearchDriver>();
    }

    public class DateFieldSearchDriver : ComponentBase
    {
        public DateFieldDriver StartDate => ByTagName("input:first-child").Wait().Find<DateFieldDriver>();
        public DateFieldDriver EndDate => ByTagName("input:last-child").Wait().Find<DateFieldDriver>();
        public DateFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator DateFieldSearchDriver(ElementFinder finder) =>
            finder.Find<DateFieldSearchDriver>();
    }

    public class DateTimeFieldSearchDriver : ComponentBase
    {
        public DateFieldDriver StartDate => ByTagName("input:first-child").Wait().Find<DateFieldDriver>();
        public DateFieldDriver EndDate => ByTagName("input:last-child").Wait().Find<DateFieldDriver>();
        public DateTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator DateTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<DateTimeFieldSearchDriver>();
    }

    public class FileFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver FileName => ByTagName("[data-search-target='filename'] input").Wait().Find<TextBoxDriver>();
        public DropDownListDriver FileNameMatch => ByTagName("[data-search-target='filename'] select").Wait().Find<DropDownListDriver>();
        public TextBoxDriver MinFileSize => ByTagName("[data-search-target='file-size'] input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver MaxFileSize => ByTagName("[data-search-target='file-size'] input:last-child").Wait().Find<TextBoxDriver>();
        public FileFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator FileFieldSearchDriver(ElementFinder finder) =>
            finder.Find<FileFieldSearchDriver>();
    }

    public class LinkFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait().Find<TextBoxDriver>();
        public ButtonDriver Clear => ByCssSelector("button.btn-close").Wait().Find<ButtonDriver>();
        public ButtonDriver Search => ByCssSelector("button:has(.bi-search)").Wait().Find<ButtonDriver>();
        public LinkFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator LinkFieldSearchDriver(ElementFinder finder) =>
            finder.Find<LinkFieldSearchDriver>();
    }

    public class ListFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public ListFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator ListFieldSearchDriver(ElementFinder finder) =>
            finder.Find<ListFieldSearchDriver>();
    }

    public class ModuleSelectFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public ModuleSelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator ModuleSelectFieldSearchDriver(ElementFinder finder) =>
            finder.Find<ModuleSelectFieldSearchDriver>();
    }

    public class NumberFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Min => ByTagName("input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver Max => ByTagName("input:last-child").Wait().Find<TextBoxDriver>();
        public NumberFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator NumberFieldSearchDriver(ElementFinder finder) =>
            finder.Find<NumberFieldSearchDriver>();
    }

    public class RadioGroupFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public RadioGroupFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator RadioGroupFieldSearchDriver(ElementFinder finder) =>
            finder.Find<RadioGroupFieldSearchDriver>();
    }

    public class SelectFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public SelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator SelectFieldSearchDriver(ElementFinder finder) =>
            finder.Find<SelectFieldSearchDriver>();
    }

    public class TextFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait().Find<TextBoxDriver>();
        public DropDownListDriver Match => ByTagName("select").Wait().Find<DropDownListDriver>();
        public TextFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator TextFieldSearchDriver(ElementFinder finder) =>
            finder.Find<TextFieldSearchDriver>();
    }

    public class TimeFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver StartTime => ByTagName("input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver EndTime => ByTagName("input:last-child").Wait().Find<TextBoxDriver>();
        public TimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator TimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<TimeFieldSearchDriver>();
    }

    public class LabelFieldSearchDriver : ComponentBase
    {
        public IWebElement Label => ByTagName("label").Wait().Find();
        public LabelFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator LabelFieldSearchDriver(ElementFinder finder) => finder.Find<LabelFieldSearchDriver>();
    }
}
