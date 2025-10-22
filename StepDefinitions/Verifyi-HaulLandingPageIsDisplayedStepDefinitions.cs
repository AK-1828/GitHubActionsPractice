using static MobileAutomation.Pages.VerifyiHaulLandingPages;

namespace MobileAutomation.StepDefinitions
{
    [Binding]
    public class VerifyiHaulWelcomePageIsDisplayedStepDefinitions
    {
       /* [Then("Home Page should display text {string}")]
        public void ThenHomePageShouldDisplayText(string homePageText)
        {
            VerifyLandingPageContainsText(homePageText);
        }*/

        [Then("{string} page is displayed")]
        public void ThenPageIsDisplayed(string SandC)
        {
            // ClickOnNextButton();
            VerifyLandingPageContainsText(SandC);
        }

    }
}
