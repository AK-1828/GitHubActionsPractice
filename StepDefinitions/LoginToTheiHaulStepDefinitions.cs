using System;
using Reqnroll;
using static iHaul.Pages.VerifyiHaulLoginPage;
using static iHaul.HelperClass.MailSlurpHelper;
using OpenQA.Selenium.Appium.Enums;

namespace iHaul.StepDefinitions
{
    [Binding]
    public class LoginToTheiHaulStepDefinitions
    {
        [Given("click on the next button")]
        public void ClickOnTheNextButton()
        {
            clickOnSkipbutton();

        }

        [When("enter the mobile number {string}")]
        public void EnterTheMobileNumber(string mobileNumber)
        {

            enterTheMobileOrEmail(mobileNumber);
            

        }


        [When("click on continue button")]
        public void WhenClickOnContinueButton()
        {

            clickOnContinueButton();
            Thread.Sleep(10000);

        }

        [When("enter the code {string},{string}")]
        public void  WhenEnterTheCode(string email, string appPassword)
        {
           // string prefix = "ak45test";
            EnterOtpFromGmail(email, appPassword);
          // enterEmialOtpFromRegisteredEmail();
        }

        [When("click on login button")]
        public void WhenClickOnLoginButton()
        {
            clickOnLoginButton();
        }

        [When("click on ok button")]
        public void WhenClickOnOkButton()
        {
            clickOnOKButton();
        }

        [When("click on use password instead")]
        public void WhenClickOnUsePasswordInstead()
        {
            clickOnUsePasswordinstead();
        }

        [When("enter password {string}")]
        public void WhenEnterPassword(string password)
        {
            enterPassword(password);
        }

      
    }
}
