using SeleniumFramework.Base;
using SeleniumFramework.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.StepDefinitions
{
    [Binding]
    public class LoginStepDef : BaseClass
    {
        public LoginPage login;

        public LoginStepDef(Drivercontext drivercontext): base(drivercontext)   
        {
            
        }
        [Given(@"User enter firstname")]
        public void GivenUserEnterFirstname()
        {
           LoginPage login= new LoginPage(_drivercontext);
            login.FillRequestForm();
        }
    }
}