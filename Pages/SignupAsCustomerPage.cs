
using iHaul.HelperClass;
using mailslurp.Model;
using Microsoft.VisualBasic.FileIO;
using MobileAutomation.Assertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.MailSlurpHelper;
using static iHaul.HelperClass.SynchMethods;
using static iHaul.HelperClass.WaitingTime;
using static iHaul.Locators.SignupAsCustomerLocators;
using static iHaul.Pages.VerifyiHaulLoginPage;
using static iHaul.Reqnroll.Drivers.DriverManager;
using static iHaul.Utilities.Configure;


namespace iHaul.Pages
{
    public class SignupAsCustomerPage
    {


        public static Guid inboxId;
        public static void verifyWelcomeToiHaulPageIsDisplayed(String expectedText)
        {
            string welcomeToiHaulText = GetElementAttribute(welcomeText, "content-desc", longWait);
            Console.WriteLine(welcomeToiHaulText);
            Asserts.AreEqual(expectedText, welcomeToiHaulText, "Welcome page is not displayed");
        }
        public static void enterMobileNumber()
        {
            String number = GenerateRandomMobileNumber();
            WaitUntilElementVisible(enterYourEmailOrMobile,mediumWait);
            SafeClick(enterYourEmailOrMobile, mediumWait);
            EnterText(enterYourEmailOrMobile, number, longWait);
            SafeHideKeyboard();
        }

        public static void selectRole()
        {
            SafeClick(customerRole, longWait);
        }

        public static void enterFirstName()
        {
            String firstName = GenerateRandomString();
            SafeClick(firstNameInputField, mediumWait);
            EnterText(firstNameInputField, firstName, longWait);
            SafeHideKeyboard();
        }

        public static void enterLastName()
        {
            String lastName = GenerateRandomString();
            SafeClick(lastNameInputField, mediumWait);
            EnterText(lastNameInputField, lastName, longWait);
            SafeHideKeyboard();
        }

        public static void enterEmail()
        {
            InboxDto inbox = CreateNewInbox();
            if (inbox == null)
            {
                Console.WriteLine("❌ Failed to create inbox: inbox is null.");
                throw new Exception("Failed to create inbox.");
            }

            // ✅ Set inboxId here
            inboxId = inbox.Id;

            string emailAddress = inbox.EmailAddress;
            Console.WriteLine($"📥 Created inbox with ID: {inboxId} and email: {emailAddress}");

           // string emailAddress = "e893d966 - 9b1a - 4836 - 83a1 - 324355fecace @mailslurp.biz";

            SafeClick(emailInputField, mediumWait);
            EnterText(emailInputField, emailAddress, mediumWait);
            SafeHideKeyboard();
        }

        public static void clickOnDateOfBirthField()
        {
            SafeClick(dateOfBirth, mediumWait);
        }

        public static void ScrollToAndSelectYear(string year)
        {
            try
            {
                Driver.FindElement(MobileBy.AccessibilityId(year)).Click();
            }
            catch
            {
                // Fallback to scrollable strategy using UiScrollable
                string uiSelector = $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().description(\"{year}\"));";
                Driver.FindElement(MobileBy.AndroidUIAutomator(uiSelector)).Click();
            }
        }


        public static void WaitUntilTheVerifyNoAccountPromptAndInitiateSignupNotificationIsDisappers()
        {
            WaitUntilElementDisappears(NonAccountSignuotNotification, longWait);
        }

        public static void selectTheDate(String date)
        {
            By dateField = By.XPath($"//android.widget.Button[contains(@content-desc, '{date}')]");
            SafeClick(dateField,mediumWait);
        }

        public static void clickOnOK()
        {
            SafeClick(ok, mediumWait);
        }

        public static void clickOnGenderDropdown()
        {
            WaitUntilElementVisible(genderDropdown,mediumWait);
            SafeClick(genderDropdown, mediumWait);
        }

        public static void selectGender()
        {
            WaitUntilElementVisible(male, mediumWait);
            SafeClick(male, mediumWait);
        }

        public static void clickOnTermsOfUseAndPrivacyPolicy()
        {
            WaitUntilElementVisible(termsOfUseAndPrivacy, mediumWait);
            SafeClick(termsOfUseAndPrivacy, mediumWait);
        }

        public static void clickOnSignUp()
        {
            WaitUntilElementVisible(signUpButton, mediumWait);
            SafeClick(signUpButton, mediumWait);   
        }

        public static void enterMobileOTP(String otp)
        {
            WaitUntilElementVisible(phoneNumberOTPInputField,mediumWait);
            SafeClick(phoneNumberOTPInputField,mediumWait);
            EnterText(phoneNumberOTPInputField, otp,mediumWait);
            SafeHideKeyboard();
        }

        public static void enterEmailOTP()
        {
            Console.WriteLine($"📩 Using inbox ID: {inboxId}");

            var email = WaitForLatestEmail(inboxId);

            if (email == null)
            {
                Console.WriteLine("❌ No email received.");
                throw new Exception($"No email received in inbox {inboxId}");
            }

            if (email.Body == null)
            {
                Console.WriteLine("❌ Email body is null.");
                throw new Exception("Email received but body is null.");
            }

            string otp = ExtractOtpFromBody(email.Body);

            Console.WriteLine($"✅ OTP extracted: {otp}");

            SafeClick(emailOTPInputField, mediumWait);
            EnterText(emailOTPInputField, otp, mediumWait);
            SafeHideKeyboard();
        }

        public static void clickOnVerifyButton()
        {
            WaitUntilElementVisible(verifyButton, mediumWait);
            SafeClick(verifyButton, mediumWait);    
        }

        public static void verifySuccessfuVerificationMessage(String expectedText)
        {
            String actVerficationMessage = GetElementAttribute(verificationMessage,"content-desc",mediumWait);
            Console.WriteLine(actVerficationMessage);
            Assert.IsTrue(actVerficationMessage.Contains(expectedText),
               $"Expected text to contain: '{expectedText}', but got: '{actVerficationMessage}'");
        }

        public static void clickOnOkButton()
        {
            WaitUntilElementVisible(okButton, mediumWait);
            SafeClick(okButton,mediumWait);
        }

        public static void clickOnAllowLocation()
        {
            WaitUntilElementVisible(allowLocation, mediumWait);
            SafeClick(allowLocation, mediumWait);
        }

        public static void clickOnWhileUsingTheApp()
        {
            WaitUntilElementVisible(whileUsingTheApp, mediumWait);
            SafeClick(whileUsingTheApp, mediumWait);
        }

        public static void allowNotification()
        {
            WaitUntilElementVisible(allowNotifications, mediumWait);
            SafeClick(allowNotifications, mediumWait);
        }

       
    }
}
