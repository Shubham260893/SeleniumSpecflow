using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Base
{
    public class BaseClass
    {

        public Drivercontext _drivercontext;
      
        public BaseClass(Drivercontext drivercontext)
        {
            this._drivercontext = drivercontext;
        }


    }
}
