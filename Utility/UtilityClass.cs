

using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridPOMFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HybridPOMFramework.Utility
{
    public class UtilityClass : ConfigClass
    {
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
        }

        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public void waitTillElement(By locator)
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(locator);
                return element.Displayed;
            });

        }

        public void CaptureScreenshot()
        {
            //Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            //DateTime currentDate = DateTime.Now;
            //string fileName = $"Screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
            //screenshot.SaveAsFile(screenshotPath + fileName);

            Directory.CreateDirectory(screenshotPath); // creates only if missing
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string fileName = $"Screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
            screenshot.SaveAsFile(Path.Combine(screenshotPath, fileName));

        }
        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
