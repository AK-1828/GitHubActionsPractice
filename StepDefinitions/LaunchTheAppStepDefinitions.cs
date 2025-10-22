using static iHaul.Reqnroll.Drivers.AppiumDriverSetup;


namespace MobileAutomation.StepDefinitions
{
    [Binding]

    public class LaunchTheAppStepDefinitions
    {
     
        [Given("launch the i-Haul app")]
        public void GivenLaunchTheI_HaulApp()
        {
           LaunchApp("app");
            Thread.Sleep(5000);
        }
    }
}
