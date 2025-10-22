using static iHaul.Pages.EnableOrDisbaleAlertsForCustomerPage;

namespace iHaul.StepDefinitions
{
    [Binding]
    public class EnableOrDisbaleAlertsFromCustomeStepDefinitions
    {
        [When("click on alerts")]
        public void WhenClickOnAlerts()
        {
            clickOnAlerts();
        }

        [When("enable the bid alerts toggle")]
        public void WhenEnableTheBidAlertsToggle()
        {
            enableBidAlerts();
        }

        [When("disable the bid alerts toggle")]
        public void WhenDisableTheBidAlertsToggle()
        {
            disableBidAlerts();
        }

        [When("enable the haul alerts toggle")]
        public void WhenEnableTheHaulAlertsToggle()
        {
            enableHaulAlerts();
        }

        [When("disable the haul alerts toggle")]
        public void WhenDisableTheHaulAlertsToggle()
        {
           disableHaulAlerts();
        }
    }
}
