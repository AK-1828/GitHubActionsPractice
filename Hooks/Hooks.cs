using iHaul.Utilities;
using MobileAutomation.AllureReporting;
using iHaul.Reqnroll.Drivers;
using System.Diagnostics;
using static iHaul.HelperClass.MailSlurpHelper;
using static iHaul.Reqnroll.Drivers.AppiumDriverSetup;
using static iHaul.Reqnroll.Drivers.AppiumServiceManager;

namespace iHaul.Hooks
{
   
    [Binding]
    public class Hooks
    {
        
        private readonly ScenarioContext _scenarioContext;
        private static bool _isInitialized = false;
        private string webUrl;
        private string emulatorName ;
        private string mailSurpApiKey;
        private string packageName;


        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Configure.Init("TestData","appProperties.json");
            webUrl = Configure.Get("MobileWebUrl");
            emulatorName = Configure.Get("EmulatorName");
            mailSurpApiKey = Configure.Get("MailSurpAPIKey");
            packageName = Configure.Get("PackageName"); 

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
           
           StartAppiumServer();

           // EmulatorLauncher.StartEmulator(emulatorName);
            //AppiumDriverSetup.InitializeDriver("chrome", webUrl);
          launchApp("app");
          Initialize(mailSurpApiKey);


           
        }

        [AfterScenario]        
        public void AfterScenario()
        {
            QuitDriver();
            StopAppiumServer();
            ForceCloseApp(packageName);
        }

        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError != null)
            {
                string stepName = _scenarioContext.StepContext.StepInfo.Text;
                AllureScreenshot.getScrShot(stepName);
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            AllureReports.ArchiveAllureResults();
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c GenerateAndOpenAllureReport.bat",
                WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process.Start(psi);
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            AllureReports.CleanAllureResultsFolder();

        }
    }
}
