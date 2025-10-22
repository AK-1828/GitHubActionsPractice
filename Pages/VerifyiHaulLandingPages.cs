using MobileAutomation.Assertions;
using NUnit.Framework;
using OpenQA.Selenium;
using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.WaitingTime;
using static MobileAutomation.Locators.VerifyiHaulLandingPageLocators;


namespace MobileAutomation.Pages
{
    public class VerifyiHaulLandingPages
    {
        public static void verifyTheWelcomePageIsDisplayed(string expectedText)
        {
            string actualText = GetElementAttribute(HomePageWelcomeText, "content-desc", longWait);
            Assert.IsTrue(actualText.Contains(expectedText),
                $"Expected text to contain: '{expectedText}', but got: '{actualText}'");
        }
        public static void ClickOnNextButton()
        {
            SafeClick(NextButton, longWait);
        }
        public static void VerifyTheSimpleAndConvenientPageIsDisplayed(string expectedText)
        {
            String sAndC = GetElementAttribute(SimpleAndConvenient, "content-desc", longWait);
            Assert.IsTrue(sAndC.Contains(expectedText),
                $"Expected text to contain: '{expectedText}', but got: '{sAndC}'");
        }


        public static void VerifyLandingPageContainsText(string expectedText)
        {
            var locator = By.XPath($"//android.widget.ImageView[contains(@content-desc,'{expectedText}')]");
            string actualText = string.Empty;
            bool isTextFound = false;

            // Try up to 3 times (Initial + 2 Next clicks)
            for (int attempt = 0; attempt < 3; attempt++)
            {
                try
                {
                    actualText = GetElementAttribute(locator, "content-desc", shortWait);
                    Console.WriteLine($"[Attempt {attempt + 1}] Found text: {actualText}");

                    isTextFound = !string.IsNullOrEmpty(actualText) && actualText.Contains(expectedText);

                    if (isTextFound)
                    {
                        Assert.IsTrue(true, $"Expected text '{expectedText}' found on attempt {attempt + 1}.");
                        return;
                    }

                    if (attempt < 2) // Only click Next for the first two attempts
                    {
                        SafeClick(NextButton, longWait);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Attempt {attempt + 1}] Exception: {ex.Message}");
                    // Still try to continue to next screen
                    if (attempt < 2)
                    {
                        SafeClick(NextButton, longWait);
                    }
                }
            }

            // Final failure if not found in all attempts
            Assert.IsTrue(false, $"Expected text '{expectedText}' was not found after 3 attempts (including 2 Next clicks).");
        }



    }
}
