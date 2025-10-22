using System;
using System.IO;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using iHaul.Utilities;

namespace iHaul.Reqnroll.Drivers
{
    public class AppiumDriverSetup
    {
        public static string android;
        public static string deviceName;
        public static string automationName;
        public static string chromeDriverPath;
        public static string app;

        static AppiumDriverSetup()
        {
            Configure.Init("TestData", "appProperties.json");
            android = Configure.Get("PlatformName");
            deviceName = Configure.Get("DeviceName");
            automationName = Configure.Get("AutomationName");
            chromeDriverPath = Configure.Get("ChromeDriverPath");
            app = Configure.Get("AppPath");
        }

        public static void LaunchApp(string mode = "app", string url = "")
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string lowerMode = mode.ToLower();

            var options = new AppiumOptions();

            // Basic configuration
            options.PlatformName = android;
            options.DeviceName = deviceName;
            options.AutomationName = automationName;

            options.AddAdditionalAppiumOption("appium:forceMjsonwp", false);
            options.AddAdditionalAppiumOption("disableIdLocatorAutocompletion", true);
            options.AddAdditionalAppiumOption("dontStopAppOnReset", true);
            options.AddAdditionalAppiumOption("autoGrantPermissions", true);

            //---------------- BrowserStack Integration ----------------//
            options.AddAdditionalAppiumOption("browserstack.user", "kethavathanjaney_4JAniu");
            options.AddAdditionalAppiumOption("browserstack.key", "8wzGxFyQzhpwy8WX4uFx");

            // App info
            options.AddAdditionalAppiumOption("app", "bs://sample.app");

            // Device info (you can parameterize these later)///just for fun
            options.AddAdditionalAppiumOption("platformName", "android");
            options.AddAdditionalAppiumOption("deviceName", "Samsung Galaxy S22 Ultra");
            options.AddAdditionalAppiumOption("platformVersion", "12.0");

            // Meta info
            options.AddAdditionalAppiumOption("buildName", "bstack-demo");
            options.AddAdditionalAppiumOption("projectName", "BrowserStack Sample");
            options.AddAdditionalAppiumOption("browserstack.debug", true);
            options.AddAdditionalAppiumOption("browserstack.networkLogs", true);
            options.AddAdditionalAppiumOption("browserstack.local", true);
            options.AddAdditionalAppiumOption("CUSTOM_TAG_1", "You can set a custom Build Tag here");

            //-----------------------------------------------------------//

            // App mode
            if (lowerMode == "app")
            {
                // app is already uploaded to BrowserStack, so skip local path
            }
            else if (lowerMode == "chrome")
            {
                options.BrowserName = "Chrome";
                string driverPath = Path.Combine(baseDir, chromeDriverPath);
                if (!File.Exists(driverPath))
                    throw new FileNotFoundException($"chromedriver.exe not found at path: {driverPath}");
                options.AddAdditionalAppiumOption("chromedriverExecutable", driverPath);
            }

            // 🌐 Connect to BrowserStack Hub instead of localhost
            var driver = new AndroidDriver(
                new Uri("http://hub.browserstack.com/wd/hub"), options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            if (lowerMode == "chrome" && !string.IsNullOrWhiteSpace(url))
            {
                driver.Navigate().GoToUrl(url);
            }

            DriverManager.Driver = driver;
        }

        public static void QuitDriver()
        {
            if (DriverManager.Driver != null)
            {
                Console.WriteLine("📴 Quitting Appium Driver...");
                try
                {
                    DriverManager.Driver.Quit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error quitting driver: {ex.Message}");
                }
                finally
                {
                    DriverManager.Driver = null;
                }
            }
        }
    }
}
