using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAutomation.Locators
{
    public interface VerifyiHaulLandingPageLocators
    {

        public static By HomePageWelcomeText => By.XPath("//android.widget.ImageView[contains(@content-desc,'Welcome to i-Haul!')]");
        public static By NextButton => MobileBy.AccessibilityId("Next");
        public static By SimpleAndConvenient => By.XPath("//android.widget.ImageView[contains(@content-desc,'Simple and Convenient')]");



    }
}
