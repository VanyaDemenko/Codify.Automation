﻿using OpenQA.Selenium;

namespace Codify.Automation.Core.Drivers
{
    public static class DriverHelper
    {
        public static void WaitPageFullLoaded()
        {
            DriverProvider.Wait.Until((x) =>
                ((IJavaScriptExecutor)DriverProvider.Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
