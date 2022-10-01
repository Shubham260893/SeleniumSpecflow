using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.CommonElementUtils
{
    public class WebElementUtil : BaseClass
    {
        public WebElementUtil(Drivercontext drivercontext) : base(drivercontext)
        {
        }

        public void waitForWebElementVisibility(IWebElement element,int timeout)
        {
            _drivercontext.wait = new WebDriverWait(_drivercontext.Driver, TimeSpan.FromSeconds(timeout));
          //  _drivercontext.wait.Until(ExpectedCondit)
            
        }

        public void sendKeys(IWebElement element,String text)
        {
            waitForWebElementVisibility(element, 30);
            element.SendKeys(text);
        }
    }
}
