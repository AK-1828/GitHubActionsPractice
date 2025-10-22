using HtmlAgilityPack;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.BiDi.Input;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.MailSlurpHelper;
using static iHaul.HelperClass.SynchMethods;
using static iHaul.HelperClass.WaitingTime;
using static iHaul.Locators.SignupAsCustomerLocators;
using static iHaul.Locators.VerifyiHaulLoginLocators;
using static iHaul.Reqnroll.Drivers.DriverManager;
using static iHaul.Utilities.Configure;
using static System.Net.WebRequestMethods;


namespace iHaul.Pages
{
    public static class VerifyiHaulLoginPage
    {
        // public static Guid inboxId;
        public static readonly Guid existingInboxId = Guid.Parse("aee5f41e-a3e4-443b-a2b9-f53cb79eed31");

        private static WaitForControllerApi _waitForControllerApi;
        private static Configuration _config;
        private static string apiKey = "081badeef87cf148b49ddd037e0097cdca60535f9c700fac73106c3555004d04";
        private static readonly HttpClient client = new HttpClient();
        public static void clickOnSkipbutton()
        {
            SafeClick(skipButton, shortWait);
        }

        public static void enterTheMobileOrEmail(String mobileNumber)
        {
           
            SafeClick(enterYourEmailOrMobile, mediumWait);
            EnterText(enterYourEmailOrMobile, mobileNumber, mediumWait);
            SafeHideKeyboard();
        }
        public static void clickOnContinueButton()
        {
            WaitUntilElementVisible(continueButton,mediumWait);
            SafeClick(continueButton, mediumWait);
        }

     
        public static Email WaitForLatestRegisteredEmail(Guid inboxId, long timeoutMillis = 30000)
        {
            _config = new Configuration();
            _config.ApiKey.Add("x-api-key", apiKey);
            _waitForControllerApi = new WaitForControllerApi(_config);
            return _waitForControllerApi.WaitForLatestEmail(existingInboxId, timeoutMillis);
        }

        public static void clickOnLoginButton()
        {
            WaitUntilElementVisible(loginButton,mediumWait);
            SafeClick(loginButton, mediumWait);
        }
        public static void clickOnOKButton()
        {
            WaitUntilElementVisible(okButton, mediumWait);
            SafeClick(okButton, mediumWait);
        }

        public static void EnterOtpFromGmail(string email,string appPassword)
        {
           

            string otp = GmailHelper.GetLatestOtp(email, appPassword);
            Console.WriteLine($"✅ OTP Fetched: {otp}");

            SafeClick(enterCodeInputField, mediumWait);
            EnterText(enterCodeInputField, otp, mediumWait);
            SafeHideKeyboard();
        }
        public static void clickOnUsePasswordinstead()
        {
            WaitUntilElementVisible(usePasswordInstead, mediumWait);
            SafeClick(usePasswordInstead, mediumWait);
        }

        public static void enterPassword(string password)
        {
            ScrollToElementAndClick(enterPasswordInputfield,mediumWait);
            SafeClick(enterPasswordInputfield, mediumWait);
            EnterText(enterPasswordInputfield, password, mediumWait);
            SafeHideKeyboard();

        }
        public static void enterConfirmPassword(string password)
        {
            SafeClick(confirmPassword, mediumWait);
            EnterText(confirmPassword, password, mediumWait);
            SafeHideKeyboard();
        }

    }
}
