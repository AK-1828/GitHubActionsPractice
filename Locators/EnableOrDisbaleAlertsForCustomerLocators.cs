using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using static iHaul.Reqnroll.Drivers.DriverManager;

namespace iHaul.Locators
{
    public interface EnableOrDisbaleAlertsForCustomerLocators
    {
        public static By alerts = MobileBy.AccessibilityId("Alerts");
        public static IWebElement  bidAlertsToggle = Driver.FindElement(By.XPath("//android.view.View[contains(@content-desc,'Bid Alerts')]/android.widget.Switch"));
        public static IWebElement haulAlertsToggle = Driver.FindElement(By.XPath("//android.view.View[contains(@content-desc,'Haul Alerts')]/android.widget.Switch"));

    }
}
