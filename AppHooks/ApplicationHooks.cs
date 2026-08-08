using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridPOMFramework.Pages;
using HybridPOMFramework.Utility;
using Reqnroll;

namespace HybridPOMFramework.AppHooks
{
    [Binding]
    public class ApplicationHooks : UtilityClass
    {
        public LoginPageClass loginpg;
        public AccountsOverviewClass accountpg;

        private readonly ScenarioContext scenarioContext;

        public ApplicationHooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser();
            MaximizeWindow();
            NavigateToUrl();

            loginpg = new LoginPageClass(driver);
            accountpg = new AccountsOverviewClass(driver);
        }

        

        [AfterScenario]
        public void AfterScenario()
        {



            driver.Quit();
            driver.Dispose();
        }

    }
}
