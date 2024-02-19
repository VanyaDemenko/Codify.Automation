using Codify.Automation.UI.Services;
using Codify.Automation.UI.Structures;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Codify.Automation.Tests.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginService _loginService = new();

        [Given(@"I login as a '(.*)' user to the Codify")]
        public void GivenILoginAsAUser(UserEntity user)
        {
            _loginService.LoginToCodify(user.Login!, user.Password!);
        }

        [Given(@"I login as a '(.*)' user to the Codify without password")]
        public void GivenILoginAsAUserToTheCodifyWithoutPassword(string admin)
        {
            throw new PendingStepException();
        }

        [Given(@"I login as a '(.*)' user to the Codify without login")]
        public void GivenILoginAsAUserToTheCodifyWithoutLogin(string admin)
        {
            throw new PendingStepException();
        }

        /* Actions Validation */

        [Then(@"The Codify page is loaded")]
        public void ThenTheCodifyPageIsLoaded()
        {
            throw new PendingStepException();
        }

        [Then(@"The Error Message with value '(.*)' is displayed")]
        public void ThenTheErrorMessageWithValueIsDisplayed(string expectedValue)
        {
            var actualValue = _loginService.GetErrorMessage();
            actualValue.Should().Be(expectedValue);
        }
    }
}
