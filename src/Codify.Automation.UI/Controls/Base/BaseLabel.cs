using Codify.Automation.Core.Interfaces.Controls;
using Codify.Automation.Core.PageObjects;

namespace Codify.Automation.UI.Controls.Base
{
    public class BaseLabel : Container, IGetValue
    {
        public virtual string GetValue()
        {
            return Element.GetAttribute("innerText");
        }
    }
}
