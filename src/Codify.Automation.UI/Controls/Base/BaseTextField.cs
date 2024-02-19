using Codify.Automation.Core.Extensions;
using Codify.Automation.Core.Interfaces.Controls;
using Codify.Automation.Core.PageObjects;

namespace Codify.Automation.UI.Controls.Base
{
    public class BaseTextField : Container, ISetValue, IGetValue
    {
        public virtual void SetValue(string value)
        {
            Element.SetValueAndFocusOut(value);
        }

        public virtual string GetValue()
        {
            return Element.GetAttribute("value");
        }
    }
}
