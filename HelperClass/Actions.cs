
using iHaul.Reqnroll.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;
using System;
using System.Net.Http;
using HtmlAgilityPack;
using OpenQA.Selenium.Appium;

using static iHaul.Reqnroll.Drivers.DriverManager;



namespace iHaul.HelperClass
{
    public class Actions
    {

       
        public static void SafeClick(By locator, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                element.Click();
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"[TIMEOUT ERROR] Element not clickable after {timeoutInSeconds} seconds: {locator}");
                throw;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"[NOT FOUND ERROR] Element not found: {locator}");
                throw;
            }
            catch (ElementClickInterceptedException ex)
            {
                Console.WriteLine($"[CLICK ERROR] Element click intercepted: {locator}");
                throw;
            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine($"[STALE ERROR] Stale element reference: {locator}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UNKNOWN ERROR] Unexpected exception while clicking {locator}: {ex.Message}");
                throw;
            }
        }


        public static void EnterText(By locator, string text, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
                // element.Clear();
                element.SendKeys(text);
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"[TIMEOUT ERROR] Element not visible after {timeoutInSeconds} seconds: {locator}");
                throw;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"[NOT FOUND ERROR] Element not found: {locator}");
                throw;
            }
            catch (InvalidElementStateException ex)
            {
                Console.WriteLine($"[STATE ERROR] Element not in a state to send keys: {locator}");
                throw;
            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine($"[STALE ERROR] Stale element reference while sending keys: {locator}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UNKNOWN ERROR] Unexpected error while entering text in {locator}: {ex.Message}");
                throw;
            }
        }

        public static void ScrollDownVertical()
        {
            Driver.FindElement(MobileBy.AndroidUIAutomator(
        "new UiScrollable(new UiSelector().scrollable(true)).scrollForward();"));
        }

        public static void ScrollToElementAndClick(By locator, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));

                // Try direct find
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                element.Click();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    // Try scroll with UiScrollable to bring element into view
                    string scrollableCommand = "new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView("
                                             + "new UiSelector().resourceIdMatches(\".*\"))";

                    ((AndroidDriver)Driver)
                        .FindElement(MobileBy.AndroidUIAutomator(scrollableCommand));

                    // Retry finding and clicking the element after scroll
                    WebDriverWait postScrollWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    var element = postScrollWait.Until(ExpectedConditions.ElementToBeClickable(locator));
                    element.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] Failed to scroll and click: {ex.Message}");
                    throw;
                }
            }
        }

        public static string GetElementText(By locator, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));

                return element.Text;
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"Timeout: Element with locator {locator} not found or not visible.");
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while getting text: {ex.Message}");
                return string.Empty;
            }
        }

        public void ClearAndEnterText(By locator, int timeoutInSeconds, string textToEnter)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));

                element.Clear();
                element.SendKeys(textToEnter);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"Timeout: Element not found or not visible using locator: {locator}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while entering text: {ex.Message}");
            }
        }


        public static void ScrollToElementAndClick1(By locator, int timeoutInSeconds = 30)
        {
            try
            {
                string elementText = string.Empty;

                if (locator is ByAndroidUIAutomator androidUI)
                {
                    elementText = androidUI.ToString();
                }
                else if (locator.ToString().StartsWith("By.XPath: "))
                {
                    elementText = locator.ToString();
                }

                Console.WriteLine($"[INFO] Attempting to scroll to: {elementText}");

                // Use UiScrollable to scroll into view of the target element
                string scrollCommand = $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView({ConvertLocatorToUiSelector(locator)})";

                var element = Driver.FindElement(MobileBy.AndroidUIAutomator(scrollCommand));

                // Now click the element
                element.Click();

                Console.WriteLine("[INFO] Successfully scrolled to and clicked the element.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Scroll to element and click failed: {ex.Message}");
                throw;
            }
        }

        private static string ConvertLocatorToUiSelector(By locator)
        {
            if (locator.ToString().StartsWith("By.Id: "))
            {
                string id = locator.ToString().Replace("By.Id: ", "").Trim();
                return $"new UiSelector().resourceId(\"{id}\")";
            }
            else if (locator.ToString().StartsWith("By.XPath: "))
            {
                throw new NotSupportedException("UiScrollable does not support XPath directly. Use By.Id or By.AndroidUIAutomator.");
            }
            else if (locator.ToString().StartsWith("By.Text: "))
            {
                string text = locator.ToString().Replace("By.Text: ", "").Trim();
                return $"new UiSelector().text(\"{text}\")";
            }
            else if (locator.ToString().StartsWith("ByAndroidUIAutomator: "))
            {
                // remove the prefix and just return the UiSelector part
                return locator.ToString().Replace("ByAndroidUIAutomator: ", "").Trim();
            }

            throw new NotSupportedException($"Locator type not supported for UiScrollable: {locator}");
        }

        public enum SwipeDirection
        {
            Left,
            Right
        }

        public static void SwipeUntilElementIsVisible(By sourceElementLocator, SwipeDirection swipeDirection, By targetElementLocator, int timeoutInSeconds = 15)
        {
            const double swipeRatio = 0.50;
            var driver = Driver;
            var stopwatch = Stopwatch.StartNew();

            while (stopwatch.Elapsed < TimeSpan.FromSeconds(timeoutInSeconds))
            {
                try
                {
                    var targetElement = driver.FindElement(targetElementLocator);
                    if (targetElement.Displayed)
                    {
                        Console.WriteLine("✅ Target element is now visible.");
                        return;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Continue swiping if not found
                }

                // Re-fetch source element for updated coordinates
                IWebElement sourceElement;
                try
                {
                    sourceElement = driver.FindElement(sourceElementLocator);
                }
                catch (NoSuchElementException)
                {
                    throw new NoSuchElementException($"❌ Source element not found using locator: {sourceElementLocator}");
                }

                int startX = sourceElement.Location.X + sourceElement.Size.Width / 2;
                int startY = sourceElement.Location.Y + sourceElement.Size.Height / 2;
                int screenWidth = driver.Manage().Window.Size.Width;

                int endX = swipeDirection switch
                {
                    SwipeDirection.Left => Math.Max(0, startX - (int)(sourceElement.Size.Width * swipeRatio)),
                    SwipeDirection.Right => Math.Min(screenWidth - 1, startX + (int)(sourceElement.Size.Width * swipeRatio)),
                    _ => throw new ArgumentOutOfRangeException(nameof(swipeDirection), swipeDirection, null)
                };

                int endY = startY;

                // Perform swipe
                try
                {
                    var pointer = new PointerInputDevice(PointerKind.Touch);
                    var swipe = new ActionSequence(pointer, 0);

                    swipe.AddAction(pointer.CreatePointerMove(CoordinateOrigin.Viewport, startX, startY, TimeSpan.Zero));
                    swipe.AddAction(pointer.CreatePointerDown(0));
                    swipe.AddAction(pointer.CreatePointerMove(CoordinateOrigin.Viewport, endX, endY, TimeSpan.FromMilliseconds(300)));
                    swipe.AddAction(pointer.CreatePointerUp(0));

                    driver.PerformActions(new List<ActionSequence> { swipe });
                    driver.ResetInputState(); // Important: Reset input state to allow next swipe
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ Swipe action failed: {ex.Message}");
                }

                Thread.Sleep(400); // Give UI a moment to refresh after swipe
            }

            throw new TimeoutException($"❌ Target element was not visible within {timeoutInSeconds} seconds using locator: {targetElementLocator}");
        }

        public static string GetElementAttribute(By locator, string attributeName, int timeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));

                return element.GetAttribute(attributeName);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"Timeout: Element with locator {locator} not found or not visible.");
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while getting attribute '{attributeName}': {ex.Message}");
                return string.Empty;
            }
        }

        public static void SelectImageFromGallery(string localImagePath, string deviceImagePath)
        {
            try
            {


                // Step 1: Push the file from PC to device
                Console.WriteLine("📤 Pushing image to device...");
                Driver.PushFile(deviceImagePath, new FileInfo(localImagePath));
                Console.WriteLine($"✅ Image pushed to: {deviceImagePath}");

                // Step 2: Select the image from gallery
                Console.WriteLine("📂 Selecting uploaded image from gallery...");
                By firstImageLocator = By.XPath("(//android.widget.ImageView)[1]");
                WebDriverWait wait = new(Driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(firstImageLocator)).Click();

                Console.WriteLine("✅ Image selected successfully from gallery!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error selecting image from gallery: {ex.Message}");
            }
        }

        public static void EnterTextSlowly(By locator, string textToEnter, int timeoutInSeconds)
        {
            try
            {
                // Wait for the element to be present and visible
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                var element = wait.Until(d => d.FindElement(locator));

                element.Click(); // Focus the field

                // Use Actions to simulate typing
                OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(Driver);


                foreach (char c in textToEnter)
                {
                    actions.SendKeys(c.ToString()).Perform();
                    Thread.Sleep(1000); // Delay in milliseconds between characters
                }
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"[Timeout] Element with locator {locator} not found in {timeoutInSeconds} seconds.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] Exception during slow typing: {ex.Message}");
            }
        }

        public static void SafeHideKeyboard()
        {
            try
            {
                // Check if keyboard is shown before hiding
                if (Driver.IsKeyboardShown())
                {
                    Driver.HideKeyboard();
                  
                    Console.WriteLine("Keyboard hidden successfully.");
                }
                else
                {
                    Console.WriteLine("Keyboard not shown, skipping hide.");
                }
            }
            catch (Exception ex)
            {
                // Last line of defense, ignore only the known error
                if (ex.Message.Contains("cannot be hidden") || ex is OpenQA.Selenium.UnknownErrorException)
                {
                    Console.WriteLine("SafeHideKeyboard ignored error: " + ex.Message);
                }
                else
                {
                    throw; // Only throw unexpected errors
                }
            }
        }

        public static void DismissKeyboard()
        {
            try
            {
                if (Driver.IsKeyboardShown())
                {
                    var androidDriver = Driver as AndroidDriver;
                    if (androidDriver != null)
                    {
                        androidDriver.PressKeyCode(AndroidKeyCode.Back);
                        Console.WriteLine("Keyboard dismissed using Back key.");
                    }
                    else
                    {
                        Console.WriteLine("Driver is not AndroidDriver, skipping Back key press.");
                    }
                }
                else
                {
                    Console.WriteLine("Keyboard not visible, skipping dismissal.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Keyboard dismissal skipped: {ex.Message}");
            }
        }


        public static void MoveClockHand(By locator, int targetHour, int waitInSeconds = 10)
        {
            // ✅ Wait for element to be visible
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitInSeconds));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));

            // ✅ Get element location & size
            int startX = element.Location.X;
            int startY = element.Location.Y;
            int width = element.Size.Width;
            int height = element.Size.Height;

            // ✅ Center of the clock (hand origin)
            int centerX = startX + width / 2;
            int centerY = startY + height / 2;

            // ✅ Radius (distance from center to edge of clock)
            int radius = Math.Min(width, height) / 2 - 20; // reduce 20px to stay inside circle

            // ✅ Convert target hour into angle (30° per hour)
            double angle = (targetHour % 12) * 30;

            // ✅ Convert angle to radians
            double radians = (Math.PI / 180) * angle;

            // ✅ Target position on clock circle
            int targetX = centerX + (int)(radius * Math.Sin(radians));
            int targetY = centerY - (int)(radius * Math.Cos(radians));

            // ✅ Perform swipe (center → target hour)
            var finger = new PointerInputDevice(PointerKind.Touch, "finger");
            var sequence = new ActionSequence(finger, 0);
            sequence.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, centerX, centerY, TimeSpan.Zero));
            sequence.AddAction(finger.CreatePointerDown(MouseButton.Left));
            sequence.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, targetX, targetY, TimeSpan.FromMilliseconds(1000)));
            sequence.AddAction(finger.CreatePointerUp(MouseButton.Left));

            Driver.PerformActions(new List<ActionSequence> { sequence });
        
        }

     
       
    }



}







