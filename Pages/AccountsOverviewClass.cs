using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridPOMFramework.Utility;
using OpenQA.Selenium;

namespace HybridPOMFramework.Pages
{
    public class AccountsOverviewClass : UtilityClass
    {
        public By accountOverviewHeader = By.XPath("(//h1[@class='title'])[1]");


        public AccountsOverviewClass(IWebDriver driver)
        {
            this.driver = driver;
        }   


        public void isHeaderDisplayed()
        {
        IWebElement accountOverviewHeaderElement = driver.FindElement(accountOverviewHeader);
            Assert.That(accountOverviewHeaderElement.Displayed);
        }
    }
}
