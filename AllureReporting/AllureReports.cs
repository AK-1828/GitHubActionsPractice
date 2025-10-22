using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAutomation.AllureReporting
{
    public class AllureReports
    {
        private static readonly string SourceDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "allure-results");

        private static string GetProjectRoot()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            return Path.GetFullPath(Path.Combine(baseDir, @"..\..\.."));
        }

        public static void CleanAllureResultsFolder()
        {
            try
            {
                if (Directory.Exists(SourceDir))
                {
                    DirectoryInfo dir = new DirectoryInfo(SourceDir);

                    foreach (FileInfo file in dir.GetFiles())
                        file.Delete();

                    foreach (DirectoryInfo subDir in dir.GetDirectories())
                        subDir.Delete(true);

                    Console.WriteLine("🧹 Cleaned existing files from allure-results.");
                }
                else
                {
                    Directory.CreateDirectory(SourceDir);
                    Console.WriteLine("Created allure-results directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while cleaning allure-results: {ex.Message}");
            }
        }

        public static void ArchiveAllureResults()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string projectRoot = GetProjectRoot();
            string destinationDir = Path.Combine(projectRoot, "Allure-Reports", $"Report_{timestamp}");

            try
            {
                if (Directory.Exists(SourceDir))
                {
                    Directory.CreateDirectory(destinationDir);

                    foreach (string filePath in Directory.GetFiles(SourceDir))
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destFile = Path.Combine(destinationDir, fileName);
                        File.Copy(filePath, destFile, true);
                    }

                }
                else
                {
                    Console.WriteLine("'allure-results' folder does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while archiving Allure results: {ex.Message}");
            }
        }
    }
}
