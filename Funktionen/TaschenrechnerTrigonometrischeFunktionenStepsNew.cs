using System;
using TechTalk.SpecFlow;

namespace Funktionen
{
    [Binding]
    public class TaschenrechnerTrigonometrischeFunktionenSteps
    {
        [Given(@"The customer clicks on (.*)")]
        public void GivenTheCustomerClicksOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer enter the number (.*)")]
        public void WhenTheCustomerEnterTheNumber(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
