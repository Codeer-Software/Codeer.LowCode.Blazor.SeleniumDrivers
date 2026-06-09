using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public static class ComponentBaseExtensions
    {
        /// <summary>
        /// このフィールドの検証エラー文言を取得する。エラーが無ければ空文字を返す。
        /// </summary>
        /// <remarks>
        /// 検証エラーは <c>&lt;div class="invalid-feedback"&gt;文言&lt;/div&gt;</c> として
        /// 「無効なときだけ」描画される（ValidationFeedback.razor）。要素が無ければ＝エラー無し。
        /// 非表示でも文言を取れるよう Text ではなく textContent を読む。
        /// </remarks>
        public static string GetErrorText(this ComponentBase c)
        {
            var feedbacks = c.Element.FindElements(By.ClassName("invalid-feedback"));
            return feedbacks.Count == 0
                ? string.Empty
                : (feedbacks[0].GetAttribute("textContent") ?? string.Empty).Trim();
        }

        /// <summary>
        /// この Module（c）自身が直接持つフィールドだけを data-name で取得する。
        /// 子 Module（ModuleField）が同名フィールドを持っていても、そちらは拾わない。
        /// </summary>
        /// <remarks>
        /// DOM 上、フィールドの器（Grid/Canvas/Flow の field-layout や List の td）は
        /// すべて data-name を持ち data-layout を持たない。grid / tab コンテナだけが
        /// data-layout を持つ。よって「フィールドの器」は <c>[data-name]:not([data-layout])</c>。
        /// 子 Module のフィールドは必ず別フィールドの器（ModuleField の器）の中に入るので、
        /// 「器の中に入っていない data-name」が自分のフィールド。
        /// <para>
        /// <c>:scope</c> は c 自身を指す。ネストした ModuleField のドライバでは c 自身が
        /// 器（data-name 付き）になるため、:scope で錨を打って c 自身を境界に含めない。
        /// </para>
        /// </remarks>
        public static ElementFinder GetField(this ComponentBase c, string name)
            => c.ByCssSelector(
                $":scope [data-name='{name}']:not(:scope [data-name]:not([data-layout]) [data-name='{name}'])");
    }
}
