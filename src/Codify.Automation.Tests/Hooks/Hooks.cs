using Codify.Automation.Core.Drivers;
using Codify.Automation.Core.Enums;
using Codify.Automation.Core.Extensions;
using TechTalk.SpecFlow;

namespace Codify.Automation.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario("@UI")]
        public void BeforeScenario()
        {
            DriverProvider.StartBrowser(EnumExtensions.GetEnumByDescription<BrowserTypeEnum>("Chrome"));
            DriverProvider.Driver.Navigate().GoToUrl("URL");
            DriverHelper.WaitPageFullLoaded();
        }

        [AfterScenario("@UI")]
        public void AfterScenario()
        {
            DriverProvider.StopBrowser();
        }
    }
}
