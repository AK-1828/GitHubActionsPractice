using iHaul.Reqnroll.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using static iHaul.Reqnroll.Drivers.DriverManager;

namespace iHaul.HelperClass
{
    public class SynchMethods
    {

        public static IWebElement WaitUntilElementVisible(By locator, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
               
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"[ERROR] Element not visible after {timeoutInSeconds} seconds: {locator}");
                throw;
            }
        }
        public static IWebElement WaitUntilElementClickable(By locator, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait( Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"[ERROR] Element not clickable after {timeoutInSeconds} seconds: {locator}");
                throw;
            }
        }
        public static bool WaitUntilElementDisappears(By locator, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(driver =>
                {
                    try
                    {
                        IWebElement element = driver.FindElement(locator);
                        return !element.Displayed;
                    }
                    catch (NoSuchElementException)
                    {
                        return true; // Element not found
                    }
                    catch (StaleElementReferenceException)
                    {
                        return true; // Element detached from DOM
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[WARN] Unexpected exception while waiting for element to disappear: {ex.Message}");
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"[ERROR] Element still visible after {timeoutInSeconds} seconds: {locator}");
                return false;
            }
        }



    }
}
