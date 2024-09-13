using OpenQA.Selenium;
using Selenium.StandardControls.AdjustBrowser;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace Codeer.LowCode.Blazor.SeleniumDrivers
{
    public class ToggleButtonDriver : ControlDriverBase
    {
        public bool Checked => new CheckBoxDriver(Element.FindElement(By.TagName("input"))).Checked;

        public Action? Wait { get; set; }

        public ToggleButtonDriver(IWebElement element) : base(element) { }

        public void Edit(bool check)
        {
            var label = Element.FindElement(By.TagName("label"));
            label.Show();
            label.Focus();
            while (Checked != check)
            {
                try
                {
                    label.ClickEx();
                    if (Checked == check) break;
                    Thread.Sleep(100);
                }
                catch
                {
                    break;
                }
            }
            Wait?.Invoke();
        }

        public static implicit operator ToggleButtonDriver(ElementFinder finder) => finder.Find<ToggleButtonDriver>();

        [CaptureCodeGenerator]
        public string GetWebElementCaptureGenerator()
        {
            return $@"
                    const name = __codeerTestAssistantPro.getElementName(element);
                    const label = element.querySelector('label');
                    const input = element.querySelector('input');
                    let checked = input.checked;
                    label.addEventListener('click', function() {{ 
                       if (checked == input.checked) return;
                       checked = input.checked;
                      __codeerTestAssistantPro.pushCode(name + '.Edit(' + input.checked + ');');
                    }}, false);

                    input.addEventListener('click', function() {{ 
                       if (checked == input.checked) return;
                       checked = input.checked;
                      __codeerTestAssistantPro.pushCode(name + '.Edit(' + input.checked + ');');
                    }}, false);

";
        }
    }
}
