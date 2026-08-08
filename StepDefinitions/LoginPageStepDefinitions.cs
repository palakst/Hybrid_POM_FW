using System;
using Reqnroll;
using HybridPOMFramework.AppHooks;
using HybridPOMFramework.Pages;
namespace HybridPOMFramework.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions
    {
        private LoginPageClass loginpg;
        private AccountsOverviewClass accountpg;
        private ApplicationHooks appHooks;
        public LoginPageStepDefinitions(ApplicationHooks hooks)
        {
            appHooks = hooks;
            loginpg = appHooks.loginpg;
            accountpg = appHooks.accountpg;

        }
        [When(@"the user enters (valid|invalid) '(.*)' and '(.*)'")]
        public void WhenTheUserEntersValidAnd(string validity, string username, string password)
        {
            if (validity =="valid")
                {
                //enter correct username and password
                loginpg.EnterUsername(username);
                loginpg.EnterPassword(password);
            }

            else if (validity == "invalid")
            {
                //enter incorrect username and password
                loginpg.EnterUsername(username);
                loginpg.EnterPassword(password);
            }
        }


        [When("clicks on the login button")]
        public void WhenClicksOnTheLoginButton()
        {
            accountpg = loginpg.ClickLoginButton();
        }

        [Then("the user should be logged in successfully")]
        public void ThenTheUserShouldBeLoggedInSuccessfully()
        {
            accountpg.waitTillElement(accountpg.accountOverviewHeader);
            accountpg.isHeaderDisplayed();
        }

        

        [Then("the user should see an error message indicating invalid login credentials")]
        public void ThenTheUserShouldSeeAnErrorMessageIndicatingInvalidLoginCredentials()
        {
            throw new PendingStepException();
        }

    }
}
