using Codify.Automation.Core.PageObjects;
using Codify.Automation.Core.Utils.Attributes;
using Codify.Automation.UI.Components.Login;
using OpenQA.Selenium;

namespace Codify.Automation.UI.Pages.Login
{
    public class LoginPage : BasePage
    {
        [Titles("Login Section")]
        public LoginSectionComponent LoginSection => Select<LoginSectionComponent>(By.XPath("//..."));

        public void Login(string loginName, string password)
        {
            LoginSection.LoginTextField.SetValue(loginName);
            LoginSection.PasswordTextField.SetValue(password);
            LoginSection.LoginButton.Element.Click();
        }

        public void LoginWithotPassword(string loginName)
        {
            LoginSection.LoginTextField.SetValue(loginName);
            LoginSection.LoginButton.Element.Click();
        }

        public void LoginWithotLogin(string password)
        {
            LoginSection.PasswordTextField.SetValue(password);
            LoginSection.LoginButton.Element.Click();
        }
    }
}
