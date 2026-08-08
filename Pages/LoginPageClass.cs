using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridPOMFramework.Utility;
using OpenQA.Selenium;

namespace HybridPOMFramework.Pages
{
    public class LoginPageClass : UtilityClass
    {
        By userNameInputBox = By.Name("username");
        By passwordInputBox = By.Name("password");
        By loginButton = By.XPath("//*[@value='Log In']");

        //Constructor to initialize the driver
        public LoginPageClass(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(userNameInputBox).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordInputBox).SendKeys(password);
        }
        public AccountsOverviewClass ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
            return new AccountsOverviewClass(driver);
        }
    }
}
