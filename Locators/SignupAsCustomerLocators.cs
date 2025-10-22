using iHaul.HelperClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iHaul.HelperClass.FlutterBy;

namespace iHaul.Locators
{
    public interface SignupAsCustomerLocators
    {
        public static By welcomeText => By.XPath("//android.view.View[@content-desc='Welcome to i-Haul!']");
        public static By enterYourEmailOrMobile => MobileBy.Id("user");//By.XPath("//android.widget.EditText[@resource-id='user']");
        public static By customerRole => By.XPath("//android.widget.ImageView[contains(@content-desc,'Customer')]");

        public static By firstNameInputField => MobileBy.Id("firstName");

        public static By lastNameInputField => MobileBy.Id("lastName");
        public static By emailInputField => MobileBy.Id("email");

        public static By dateOfBirth => By.XPath("//android.view.View[contains(@content-desc,'Date of birth*')]/android.view.View[1]");
        public static By NonAccountSignuotNotification => MobileBy.AccessibilityId("It looks like you don't have an account with us. Let's do it!");
        public static By ok => MobileBy.AccessibilityId("OK");

        public static By genderDropdown => MobileBy.Id("dropdown_gender");
        public static By male => MobileBy.AccessibilityId("Male");

        public static By maleOptionFromGenderDropdown = MobileBy.Id("dropdown_item_gender_male");

        public static By termsOfUseAndPrivacy => MobileBy.Id("terms");
        // public static By termsOfUseAndPrivacy => MobileBy.AndroidUIAutomator("new UiSelector().className('android.view.View').instance(9)");
        public static By signUpButton => MobileBy.Id("sign_up");

        public static By phoneNumberOTPInputField => MobileBy.Id("phoneNumberOTP");

        public static By emailOTPInputField => MobileBy.Id("emailOTP");
        public static By verifyButton => By.XPath("//android.widget.Button[contains(@content-desc,'Verify')]");

        public static By verificationMessage => By.XPath("//android.view.View[@content-desc='Verification Successful']");

        public static By okButton => MobileBy.Id("ok");
        
        public static By allowLocation => MobileBy.Id("allow");

        public static By dontAllowLocation => MobileBy.Id("don't_allow");

        public static By allowYourLocationText = By.XPath("//android.view.View[@content-desc='Allow Your Location']");

        public static By whileUsingTheApp => By.XPath("//android.widget.Button[@text='While using the app']");

        public static By allowNotifications => By.XPath("//android.widget.Button[@text='Allow']");

        public static By scrollSection => By.XPath("//android.widget.ScrollView");

        public static By usePasswordInstead => MobileBy.AccessibilityId("Use password instead");

        public static By enterPasswordInputfield => MobileBy.Id("password");

        public static By confirmPassword => MobileBy.Id("confirm_password");


    }
            
}
