using OpenQA.Selenium;
using SeleniumFramework.Base;
using SeleniumFramework.CommonElementUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.PageObject
{

    public class LoginPage : BaseClass
    {
        public WebElementUtil webElementUtil;
        public LoginPage(Drivercontext drivercontext) : base(drivercontext)
        {
            webElementUtil = new WebElementUtil(_drivercontext);
        }

        public IWebElement firstNametxt => _drivercontext.Driver.FindElement(By.XPath("//input[@placeholder='First Name']"));


        public void FillRequestForm()
        {  
            webElementUtil.sendKeys(firstNametxt, "Shubham");
        }

        
    }
}
