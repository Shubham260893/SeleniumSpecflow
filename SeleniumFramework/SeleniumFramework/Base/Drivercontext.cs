using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Base
{
    public class Drivercontext
    {
        private IWebDriver _driver;
        private ScenarioContext scenarioContext;
        public WebDriverWait wait;



        public IWebDriver Driver { get => _driver; set => _driver = value; }
    }
}
