using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ListPage<TListLayout, TSearchLayout> : PageBase where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public ButtonDriver Create => ByCssSelector("a[data-system='create']").Wait();
        public ButtonDriver ExcelDownload => ByCssSelector("[data-system='bulk-download']").Wait();
        public ButtonDriver ExcelUpload => ByCssSelector("[data-system='bulk-upload']").Wait();
        public SearchFieldDriver<TSearchLayout> Search => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> List => ByCssSelector("div[data-system='list-field']").Wait();
        public ListPage(IWebDriver driver) : base(driver) { }
    }

    public class ListPage<TListLayout> : PageBase where TListLayout : ListLayoutBase
    {
        public ListPage(IWebDriver driver) : base(driver) { }
        public ListFieldDriver<TListLayout> List => ByCssSelector("table").Wait().Find<ListFieldDriver<TListLayout>>();
    }
}
