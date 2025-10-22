using OpenQA.Selenium.Appium.Service;
using System.Diagnostics;

namespace iHaul.Reqnroll.Drivers
{
    public class AppiumServiceManager
    {
        private static AppiumLocalService _appiumLocalService;

        public static void StartAppiumServer()
        {
            if (_appiumLocalService == null || !_appiumLocalService.IsRunning)
            {

                var builder = new AppiumServiceBuilder()
                    .UsingPort(4723)
                    .WithLogFile(new System.IO.FileInfo("appium-log.txt"));

                _appiumLocalService = builder.Build();
                _appiumLocalService.Start();
                Thread.Sleep(10000);

                Console.WriteLine("Appium Server Started at: " + _appiumLocalService.ServiceUrl);
            }
        }

        public static Uri GetServerUri()
        {
            return _appiumLocalService?.ServiceUrl;
        }

        public static void StopAppiumServer()
        {
            if (_appiumLocalService != null && _appiumLocalService.IsRunning)
            {
                try
                {
                    _appiumLocalService.Dispose();
                    Console.WriteLine("🛑 Appium Server Stopped.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error stopping Appium Server: {ex.Message}");
                }
                finally
                {
                    _appiumLocalService = null;  // Clear reference
                }
            }
        }
        public static void ForceCloseApp(string packageName)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = $"shell am force-stop {packageName}",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
    }
}
