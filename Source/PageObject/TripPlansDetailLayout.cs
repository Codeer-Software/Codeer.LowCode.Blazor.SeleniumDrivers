using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace PageObject
{
    public class TripPlansDetailLayout : ComponentBase
    {
        public LabelFieldDriver Label旅行計画 => ByCssSelector("div[data-name='Label旅行計画']").Wait();
        public LabelFieldDriver Label名称 => ByCssSelector("div[data-name='Label名称']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public LabelFieldDriver Label予算 => ByCssSelector("div[data-name='Label予算']").Wait();
        public NumberFieldDriver Budget => ByCssSelector("div[data-name='Budget']").Wait();
        public LabelFieldDriver Label出発日時 => ByCssSelector("div[data-name='Label出発日時']").Wait();
        public DateTimeFieldDriver DepartureDatetime => ByCssSelector("div[data-name='DepartureDatetime']").Wait();
        public LabelFieldDriver Label到着日 => ByCssSelector("div[data-name='Label到着日']").Wait();
        public DateFieldDriver ArrivalDate => ByCssSelector("div[data-name='ArrivalDate']").Wait();
        public LabelFieldDriver Labelしおり => ByCssSelector("div[data-name='Labelしおり']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public ImageViewerFieldDriver ImageViewerしおり => ByCssSelector("div[data-name='ImageViewerしおり']").Wait();
        public LabelFieldDriver Label確定 => ByCssSelector("div[data-name='Label確定']").Wait();
        public BooleanFieldDriver Fixed => ByCssSelector("div[data-name='Fixed']").Wait();
        public LabelFieldDriver Label目的地一覧 => ByCssSelector("div[data-name='Label目的地一覧']").Wait();
        public DetailListFieldDriver<DestinationsDetailLayout> DetailList目的地 => ByCssSelector("div[data-name='DetailList目的地']").Wait();
        public LabelFieldDriver Label交通手段 => ByCssSelector("div[data-name='Label交通手段']").Wait();
        public ListFieldDriver<TransportationListLayout> List交通手段 => ByCssSelector("div[data-name='List交通手段']").Wait();
        public SubmitButtonFieldDriver 保存 => ByCssSelector("div[data-name='保存']").Wait();

        public TripPlansDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator TripPlansDetailLayout(ElementFinder finder) => finder.Find<TripPlansDetailLayout>();
    }

    public class TripPlansDetailPage : DetailPage<TripPlansDetailLayout>
    {

        public TripPlansDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class TripPlansDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/TripPlans/")]
        public static TripPlansDetailPage AttachTripPlansDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/TripPlans/");
            return new TripPlansDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<TripPlansDetailLayout> AttachTripPlansDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='TripPlans']").Wait();

    }

}
