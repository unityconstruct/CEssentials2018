using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Entering into Calc");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Pressing Add Button");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Result Shows");
        }
    }
}
