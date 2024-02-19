using Codify.Automation.Core.Drivers;
using Codify.Automation.Core.Factories;
using Codify.Automation.Core.Services;
using Codify.Automation.UI.Pages.Login;

namespace Codify.Automation.UI.Services
{
    public class LoginService : IService
    {
        private LoginPage _loginPage { get; }

        public LoginService() => _loginPage = EntryPageFactory.Create<LoginPage>(DriverProvider.Driver);

        public void LoginToCodify(string loginName, string password)
        {
            _loginPage.Login(loginName, password);
            DriverHelper.WaitPageFullLoaded();
        }

        public void LoginToCodifyWithotPassword(string loginName)
        {
            _loginPage.LoginWithotPassword(loginName);
            DriverHelper.WaitPageFullLoaded();
        }

        public void LoginToCodifyWithotLogin(string password)
        {
            _loginPage.LoginWithotLogin(password);
            DriverHelper.WaitPageFullLoaded();
        }

        public string GetErrorMessage() => _loginPage.LoginSection.ErrorMessage.GetValue();
    }
}
