using Codify.Automation.Core.PageObjects;
using Codify.Automation.UI.Controls.Base;
using OpenQA.Selenium;

namespace Codify.Automation.UI.Components.Login
{
    public class LoginSectionComponent : Container
    {
        public BaseTextField LoginTextField => Select<BaseTextField>(By.XPath(".//..."));

        public BaseTextField PasswordTextField => Select<BaseTextField>(By.XPath(".//..."));

        public BaseButton LoginButton => Select<BaseButton>(By.XPath(".//..."));

        public BaseLabel ErrorMessage => Select<BaseLabel>(By.XPath(".//..."));
    }
}
