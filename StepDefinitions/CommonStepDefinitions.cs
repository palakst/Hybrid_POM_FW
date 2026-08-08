using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reqnroll;
using HybridPOMFramework.AppHooks;

namespace HybridPOMFramework.StepDefinitions
{
    [Binding]
    public class CommonStepDefinitions
    {
        private ApplicationHooks appHooks;

        public CommonStepDefinitions(ApplicationHooks hooks)
        {
            appHooks = hooks;

        }
        [Given("browser is launched")]
        public void GivenBrowserIsLaunched()
        {
        //done in app hooks
        }

        [Given("application is open")]
        public void GivenApplicationIsOpen()
        {
            //done in app hooks
        }

        [Given("user is on landing page")]
        public void GivenUserIsOnLandingPage()
        {
            //done in app hooks
        }

       
    }
}
