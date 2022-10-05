using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Base
{
    public class BrowserFactory : BaseClass
    {
        public BrowserFactory(Drivercontext drivercontext): base(drivercontext)
        {

        }

        public static  String PropertyValue(String propertyKey)
        {
            String value = ConfigurationManager.AppSettings[propertyKey];
            return value;
        }

        public void OpenBrowser()
        {
            String browserName = PropertyValue("browser");
           // String browserName = "chrome";
            switch (browserName.ToLower())
            {
                case "chrome":

                    _drivercontext.Driver = new ChromeDriver();
                    break;
            }
        }
            public void GoToURL()
            {
                String urlString = PropertyValue("url");
                _drivercontext.Driver.Navigate().GoToUrl(urlString);
                
            }

        public void TearDown()
        {
            _drivercontext.Driver.Dispose();
        }
        }
    }

