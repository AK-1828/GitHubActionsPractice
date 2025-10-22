using System;
using OpenQA.Selenium.BiDi.Browser;
using Reqnroll;
using static iHaul.Pages.VerifyiHaulLoginPage;
using static iHaul.Pages.SignupAsCustomerPage;




namespace iHaul.StepDefinitions
{
    [Binding]
    public class SignupAsCustmerStepDefinitions
    {
        [When("click on skip button")]
        public void ClickOnSkipButton()
        {
            clickOnSkipbutton();
        }

        [Then("verify that {string} is displayed")]
        public void VerifyThatIsDisplayed(string welcomeText)
        {
            verifyWelcomeToiHaulPageIsDisplayed(welcomeText);
        }

        [When("enter the mobile number")]
        public void EnterTheMobileNumber()
        {
            enterMobileNumber();
        }

        [When("select role")]
        public void SelectCustomer()
        {
          WaitUntilTheVerifyNoAccountPromptAndInitiateSignupNotificationIsDisappers();
            selectRole();
        }

        [When("enter first name")]
        public void EnterFirstName()
        {
           enterFirstName();
        }

        [When("enter last name")]
        public void EnterLastName()
        {
         enterLastName();   
        }

        [When("enter email")]
        public void EnterEmail()
        {
            enterEmail();
        }

        [When("enter date of birth")]
        public void EnterDateOfBirth()
        {
            clickOnDateOfBirthField();
            ScrollToAndSelectYear("1996");
            selectTheDate("September 29");
            clickOnOK();
        }

        [When("select gender")]
        public void SelectGender()
        {
           // clickOnGenderDropdown();
            selectGender();
        }

        [When("accept terms and privacy policy")]
        public void AcceptTermsAndPrivacyPolicy()
        {
            clickOnTermsOfUseAndPrivacyPolicy();
        }

        [When("click on signup button")]
        public void ClickOnSignupButton()
        {
            clickOnSignUp();
        }

        [When("enter the {string} code sent to your mobile number")]
        public void EnterTheCodeSentToYourMobileNumber(string mobileOtp)
        {
            enterMobileOTP(mobileOtp);
        }

        [When("enter the code sent to your email")]
        public void EnterThe_DigitCodeSentToYourEmail()
        {
            enterEmailOTP();
        }

        [When("click on verify button")]
        public void ClickOnVerifyButton()
        {
            clickOnVerifyButton();
        }

        [Then("verify {string} message")]
        public void VerifyMessage(string expectedVerificationText)
        {
            verifySuccessfuVerificationMessage(expectedVerificationText);
        }

        [When("click on OK")]
        public void ClickOnOK()
        {
            clickOnOkButton();
        }

        [When("allow notification")]
        public void WhenAllowNotification()
        {
            allowNotification();
        }


        [When("click on allow location")]
        public void ClickOnAllowLocation()
        {
            clickOnAllowLocation();
        }

        [When("click on while using the app")]
        public void ClickOnWhileUsingTheApp()
        {
            clickOnWhileUsingTheApp();
        }

        [When("enter create password {string}")]
        public void WhenEnterCreatePassword(string password)
        {
            enterPassword(password);
        }

        [When("enter confirm passowrd {string}")]
        public void WhenEnterConfirmPassowrd(string password)
        {
            enterConfirmPassword(password);
        }


    }
}
