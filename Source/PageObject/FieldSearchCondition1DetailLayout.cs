using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class FieldSearchCondition1DetailLayout : ComponentBase
    {
        public LabelFieldDriver BooleanLinkLabel => ByCssSelector("div[data-name='BooleanLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> BooleanLink => ByCssSelector("div[data-name='BooleanLink']").Wait();
        public LabelFieldDriver DateStartLinkLabel => ByCssSelector("div[data-name='DateStartLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> DateStartLink => ByCssSelector("div[data-name='DateStartLink']").Wait();
        public LabelFieldDriver DateEndLinkLabel => ByCssSelector("div[data-name='DateEndLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> DateEndLink => ByCssSelector("div[data-name='DateEndLink']").Wait();
        public LabelFieldDriver DateTimeStartLinkLabel => ByCssSelector("div[data-name='DateTimeStartLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> DateTimeStartLink => ByCssSelector("div[data-name='DateTimeStartLink']").Wait();
        public LabelFieldDriver DateTimeEndLinkLabel => ByCssSelector("div[data-name='DateTimeEndLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> DateTimeEndLink => ByCssSelector("div[data-name='DateTimeEndLink']").Wait();
        public LabelFieldDriver IdLinkLabel => ByCssSelector("div[data-name='IdLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> IdLink => ByCssSelector("div[data-name='IdLink']").Wait();
        public LabelFieldDriver LinkLinkLabel => ByCssSelector("div[data-name='LinkLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> LinkLink => ByCssSelector("div[data-name='LinkLink']").Wait();
        public LabelFieldDriver NumberStartLinkLabel => ByCssSelector("div[data-name='NumberStartLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> NumberStartLink => ByCssSelector("div[data-name='NumberStartLink']").Wait();
        public LabelFieldDriver NumberEndLinkLabel => ByCssSelector("div[data-name='NumberEndLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> NumberEndLink => ByCssSelector("div[data-name='NumberEndLink']").Wait();
        public LabelFieldDriver RadioGroupLinkLabel => ByCssSelector("div[data-name='RadioGroupLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> RadioGroupLink => ByCssSelector("div[data-name='RadioGroupLink']").Wait();
        public LabelFieldDriver SelectLinkLabel => ByCssSelector("div[data-name='SelectLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();
        public LabelFieldDriver SelectLinkLinkLabel => ByCssSelector("div[data-name='SelectLinkLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> SelectLinkLink => ByCssSelector("div[data-name='SelectLinkLink']").Wait();
        public LabelFieldDriver TextLinkLabel => ByCssSelector("div[data-name='TextLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> TextLink => ByCssSelector("div[data-name='TextLink']").Wait();
        public LabelFieldDriver TimeStartLinkLabel => ByCssSelector("div[data-name='TimeStartLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> TimeStartLink => ByCssSelector("div[data-name='TimeStartLink']").Wait();
        public LabelFieldDriver TimeEndLinkLabel => ByCssSelector("div[data-name='TimeEndLinkLabel']").Wait();
        public LinkFieldDriver<ReadDataControlsListLayout, ReadDataControlsSearchLayout> TimeEndLink => ByCssSelector("div[data-name='TimeEndLink']").Wait();
        public LabelFieldDriver BooleanSelectLabel => ByCssSelector("div[data-name='BooleanSelectLabel']").Wait();
        public SelectFieldDriver BooleanSelect => ByCssSelector("div[data-name='BooleanSelect']").Wait();
        public LabelFieldDriver DateStartSelectLabel => ByCssSelector("div[data-name='DateStartSelectLabel']").Wait();
        public SelectFieldDriver DateStartSelect => ByCssSelector("div[data-name='DateStartSelect']").Wait();
        public LabelFieldDriver DateEndSelectLabel => ByCssSelector("div[data-name='DateEndSelectLabel']").Wait();
        public SelectFieldDriver DateEndSelect => ByCssSelector("div[data-name='DateEndSelect']").Wait();
        public LabelFieldDriver DateTimeStartSelectLabel => ByCssSelector("div[data-name='DateTimeStartSelectLabel']").Wait();
        public SelectFieldDriver DateTimeStartSelect => ByCssSelector("div[data-name='DateTimeStartSelect']").Wait();
        public LabelFieldDriver DateTimeEndSelectLabel => ByCssSelector("div[data-name='DateTimeEndSelectLabel']").Wait();
        public SelectFieldDriver DateTimeEndSelect => ByCssSelector("div[data-name='DateTimeEndSelect']").Wait();
        public LabelFieldDriver IdSelectLabel => ByCssSelector("div[data-name='IdSelectLabel']").Wait();
        public SelectFieldDriver IdSelect => ByCssSelector("div[data-name='IdSelect']").Wait();
        public LabelFieldDriver LinkSelectLabel => ByCssSelector("div[data-name='LinkSelectLabel']").Wait();
        public SelectFieldDriver LinkSelect => ByCssSelector("div[data-name='LinkSelect']").Wait();
        public LabelFieldDriver NumberStartSelectLabel => ByCssSelector("div[data-name='NumberStartSelectLabel']").Wait();
        public SelectFieldDriver NumberStartSelect => ByCssSelector("div[data-name='NumberStartSelect']").Wait();
        public LabelFieldDriver NumberEndStartLabel => ByCssSelector("div[data-name='NumberEndStartLabel']").Wait();
        public SelectFieldDriver NumberEndStart => ByCssSelector("div[data-name='NumberEndStart']").Wait();
        public LabelFieldDriver RadioGroupSelectLabel => ByCssSelector("div[data-name='RadioGroupSelectLabel']").Wait();
        public SelectFieldDriver RadioGroupSelect => ByCssSelector("div[data-name='RadioGroupSelect']").Wait();
        public LabelFieldDriver SelectSelectLabel => ByCssSelector("div[data-name='SelectSelectLabel']").Wait();
        public SelectFieldDriver SelectSelect => ByCssSelector("div[data-name='SelectSelect']").Wait();
        public LabelFieldDriver SelectLinkSelectLabel => ByCssSelector("div[data-name='SelectLinkSelectLabel']").Wait();
        public SelectFieldDriver SelectLinkSelect => ByCssSelector("div[data-name='SelectLinkSelect']").Wait();
        public LabelFieldDriver TextSelectLabel => ByCssSelector("div[data-name='TextSelectLabel']").Wait();
        public SelectFieldDriver TextSelect => ByCssSelector("div[data-name='TextSelect']").Wait();
        public LabelFieldDriver TimeStartSelectLabel => ByCssSelector("div[data-name='TimeStartSelectLabel']").Wait();
        public SelectFieldDriver TimeStartSelect => ByCssSelector("div[data-name='TimeStartSelect']").Wait();
        public LabelFieldDriver TimeEndSelectLabel => ByCssSelector("div[data-name='TimeEndSelectLabel']").Wait();
        public SelectFieldDriver TimeEndSelect => ByCssSelector("div[data-name='TimeEndSelect']").Wait();
        public LabelFieldDriver BooleanListLabel => ByCssSelector("div[data-name='BooleanListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> BooleanList => ByCssSelector("div[data-name='BooleanList']").Wait();
        public LabelFieldDriver DateStartListLabel => ByCssSelector("div[data-name='DateStartListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> DateStartList => ByCssSelector("div[data-name='DateStartList']").Wait();
        public LabelFieldDriver DateEndListLabel => ByCssSelector("div[data-name='DateEndListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> DateEndList => ByCssSelector("div[data-name='DateEndList']").Wait();
        public LabelFieldDriver DateTimeStartListLabel => ByCssSelector("div[data-name='DateTimeStartListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> DateTimeStartList => ByCssSelector("div[data-name='DateTimeStartList']").Wait();
        public LabelFieldDriver DateTimeEndListLabel => ByCssSelector("div[data-name='DateTimeEndListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> DateTimeEndList => ByCssSelector("div[data-name='DateTimeEndList']").Wait();
        public LabelFieldDriver IdListLabel => ByCssSelector("div[data-name='IdListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> IdList => ByCssSelector("div[data-name='IdList']").Wait();
        public LabelFieldDriver LinkListLabel => ByCssSelector("div[data-name='LinkListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> LinkList => ByCssSelector("div[data-name='LinkList']").Wait();
        public LabelFieldDriver NumberStartListLabel => ByCssSelector("div[data-name='NumberStartListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> NumberStartList => ByCssSelector("div[data-name='NumberStartList']").Wait();
        public LabelFieldDriver NumberEndListLabel => ByCssSelector("div[data-name='NumberEndListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> NumberEndList => ByCssSelector("div[data-name='NumberEndList']").Wait();
        public LabelFieldDriver RadioGroupListLabel => ByCssSelector("div[data-name='RadioGroupListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> RadioGroupList => ByCssSelector("div[data-name='RadioGroupList']").Wait();
        public LabelFieldDriver SelectListLabel => ByCssSelector("div[data-name='SelectListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> SelectList => ByCssSelector("div[data-name='SelectList']").Wait();
        public LabelFieldDriver SelectLinkListLabel => ByCssSelector("div[data-name='SelectLinkListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> SelectLinkList => ByCssSelector("div[data-name='SelectLinkList']").Wait();
        public LabelFieldDriver TextListLabel => ByCssSelector("div[data-name='TextListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> TextList => ByCssSelector("div[data-name='TextList']").Wait();
        public LabelFieldDriver TimeStartListLabel => ByCssSelector("div[data-name='TimeStartListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> TimeStartList => ByCssSelector("div[data-name='TimeStartList']").Wait();
        public LabelFieldDriver TimeEndListLabel => ByCssSelector("div[data-name='TimeEndListLabel']").Wait();
        public ListFieldDriver<ReadDataControlsListLayout> TimeEndList => ByCssSelector("div[data-name='TimeEndList']").Wait();

        public FieldSearchCondition1DetailLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldSearchCondition1DetailLayout(ElementFinder finder) => finder.Find<FieldSearchCondition1DetailLayout>();
    }

    public class FieldSearchCondition1DetailPage : DetailPage<FieldSearchCondition1DetailLayout>
    {

        public FieldSearchCondition1DetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class FieldSearchCondition1DetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/FieldSearchCondition1")]
        public static FieldSearchCondition1DetailPage AttachFieldSearchCondition1DetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/FieldSearchCondition1");
            return new FieldSearchCondition1DetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<FieldSearchCondition1DetailLayout> AttachFieldSearchCondition1Dialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='FieldSearchCondition1']").Wait();

    }

}
