using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class UserListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public UserListLayout(IWebElement element) : base(element) { }

        public static implicit operator UserListLayout(ElementFinder finder) => finder.Find<UserListLayout>();
    }

    public class UserListPage : ListPage<UserListLayout, UserSearchLayout>
    {

        public UserListPage(IWebDriver driver) : base(driver) { }

    }

    public static class UserListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/User")]
        public static UserListPage AttachUserListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/User");
            return new UserListPage(driver);
        }

    }

}
