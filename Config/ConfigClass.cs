using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HybridPOMFramework.Config
{
    public class ConfigClass
    {
        public IWebDriver driver;
        public string url = "https://parabank.parasoft.com/parabank/overview.htm";
        public string screenshotPath = @"..\HybridPOMFramework\Screenshots\";
        public string reportPath = @"..\HybridPOMFramework\Reports\";
    }
}
