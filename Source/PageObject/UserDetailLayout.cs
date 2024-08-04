using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class UserDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelUser => ByCssSelector("div[data-name='LabelUser']").Wait();
        public LabelFieldDriver LabelID => ByCssSelector("div[data-name='LabelID']").Wait();
        public IdFieldDriver Id => ByCssSelector("div[data-name='Id']").Wait();
        public LabelFieldDriver LabelName => ByCssSelector("div[data-name='LabelName']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public SubmitButtonFieldDriver 登録ボタン => ByCssSelector("div[data-name='登録ボタン']").Wait();

        public UserDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator UserDetailLayout(ElementFinder finder) => finder.Find<UserDetailLayout>();
    }

    public class UserDetailPage : DetailPage<UserDetailLayout>
    {

        public UserDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class UserDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/User/")]
        public static UserDetailPage AttachUserDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/User/");
            return new UserDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<UserDetailLayout> AttachUserDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='User']").Wait();

    }

}
