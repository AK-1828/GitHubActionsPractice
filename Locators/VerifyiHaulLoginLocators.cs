using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHaul.Locators
{
    public interface VerifyiHaulLoginLocators
    {
        public static By skipButton => MobileBy.AccessibilityId("Skip");
        //  public static By enterYourEmailOrMobile => By.XPath("//android.widget.EditText[@resource-id='user-Enter your email or mobile']");

        public static By continueButton => MobileBy.Id("continue"); //By.XPath("//android.widget.Button[contains(@content-desc,'continue')]");

        public static By enterCodeInputField = By.XPath("//android.widget.EditText");

        public static By loginButton = MobileBy.Id("login");

      
    }

}
