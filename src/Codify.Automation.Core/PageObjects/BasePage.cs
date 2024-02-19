using Codify.Automation.Core.Drivers;
using Codify.Automation.Core.Interfaces.PageObjects;

namespace Codify.Automation.Core.PageObjects
{
    public abstract class BasePage : Container, IPage
    {
        public virtual void WaitForReadyState()
        {
            DriverHelper.WaitPageFullLoaded();
        }
    }
}
