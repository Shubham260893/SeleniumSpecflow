using SeleniumFramework.Base;
using TechTalk.SpecFlow;

namespace SeleniumFramework.StepDefinitions
{
    [Binding]
    public class Hooks : BaseClass
    {
        public BrowserFactory browserFactory;
        public Hooks(Drivercontext drivercontext): base(drivercontext)
        {

        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            browserFactory= new BrowserFactory(_drivercontext);
            browserFactory.OpenBrowser();
            browserFactory.GoToURL();
        }

        [AfterScenario]
        public void AfterScenario()
        {
           // browserFactory.TearDown();
        }
    }
}