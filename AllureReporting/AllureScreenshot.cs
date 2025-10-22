using OpenQA.Selenium;
using iHaul.Reqnroll.Drivers;
using Allure.Net.Commons;



namespace MobileAutomation.AllureReporting
{
    public class AllureScreenshot
    {
        public static void getScrShot(string stepName)
        {
            try
            {
                var screenshot = ((ITakesScreenshot)DriverManager.Driver).GetScreenshot();

                // Sanitize step name to remove invalid characters for filenames
                var invalidChars = Path.GetInvalidFileNameChars();
                var safeStepName = new string(stepName.Where(c => !invalidChars.Contains(c)).ToArray());

                string screenshotPath = Path.Combine(
                    Path.GetTempPath(),
                    $"{safeStepName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");

                screenshot.SaveAsFile(screenshotPath);

                AllureApi.AddAttachment(
                    $"Step Failure - {safeStepName}",
                    "image/png",
                    screenshotPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Screenshot capture failed: " + ex.Message);
            }
        }


        public static void TcHistoryID()
        {
            // Force a unique historyId to avoid deduplication
            AllureLifecycle.Instance.UpdateTestCase(tc =>
            {
                tc.historyId = Guid.NewGuid().ToString(); // Generate a new ID for every run
            });
        }
        public static class RunMetadata
        {
            private static readonly string RunDateKey = DateTime.Now.ToString("yyyyMMdd");
            private static readonly string CounterFilePath = @"D:\\Projects\\MobileAutomation\\MobileAutomation\\run_counter.txt"; // Store locally or in shared location
            
            public static readonly string RunLabel = GetRunLabel();

            private static string GetRunLabel()
            {
                int runNumber = GetRunNumber(); // 1 to 12
                string suffix = runNumber switch
                {
                    1 => "First",
                    2 => "Second",
                    3 => "Third",
                    4 => "Fourth",
                    5 => "Fifth",
                    6 => "Sixth",
                    7 => "Seventh",
                    8 => "Eighth",
                    9 => "Ninth",
                    10 => "Tenth",
                    11 => "Eleventh",
                    12 => "Twelth",
                    _ => $"{runNumber}th"
                };
                return $"{suffix} Hour Runs";
            }

            private static int GetRunNumber()
            {
                int runNumber = 1;
                string[] lines = File.Exists(CounterFilePath) ? File.ReadAllLines(CounterFilePath) : new string[0];

                if (lines.Length == 2 && lines[0] == RunDateKey)
                {
                    runNumber = int.Parse(lines[1]) + 1;
                }

                File.WriteAllLines(CounterFilePath, new[] { RunDateKey, runNumber.ToString() });
                return runNumber;
            }
        }

        public static void TcLabels()
        {
            AllureLifecycle.Instance.UpdateTestCase(x =>
            {
                x.labels.Add(Label.Suite(RunMetadata.RunLabel));
                x.labels.Add(new Label { name = "runId", value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") }); // your timestamp label
            });
        }

    }
}