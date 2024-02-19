using Codify.Automation.Core.PageObjects;
using OpenQA.Selenium;

namespace Codify.Automation.Core.Factories
{
    public static class EntryPageFactory
    {
        public static TPage Create<TPage>(IWebDriver driver) where TPage : BasePage, new()
        {
            return new TPage()
            {
                Driver = driver
            };
        }
    }
}
