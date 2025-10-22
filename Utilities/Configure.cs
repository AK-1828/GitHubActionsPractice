using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace iHaul.Utilities
{
    public static class Configure
    {
        private static IConfigurationRoot _config;
        private static bool _isInitialized = false;

        public static void Init(string folderName = "TestDataFolderName", string jsonFileName = "fileName")
        {
            if (_isInitialized)
                return;

            var basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Navigate to project root (3 levels up from bin/Debug/netX.X)
            var projectRoot = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;

            // Build the full path to the config file
            var fullPath = Path.Combine(projectRoot, folderName, jsonFileName);

            if (!File.Exists(fullPath))
                throw new FileNotFoundException($"Configuration file '{jsonFileName}' not found at: {fullPath}");

            _config = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(fullPath))
                .AddJsonFile(Path.GetFileName(fullPath), optional: false, reloadOnChange: true)
                .Build();

            _isInitialized = true;
        }

        public static string Get(string key)
        {
            if (!_isInitialized)
                throw new InvalidOperationException("Configuration not initialized. Call Configure.Init() first.");

            return _config[key];
        }

        public static IConfigurationRoot GetConfiguration()
        {
            if (!_isInitialized)
                throw new InvalidOperationException("Configuration not initialized. Call Configure.Init() first.");

            return _config;
        }

        public static string GenerateRandomMobileNumber()
        {
            Random random = new Random();
            string prefix = "9"; // Choose a valid starting digit: 6, 7, 8, or 9
            string number = prefix;

            for (int i = 1; i < 10; i++)
            {
                number += random.Next(0, 10).ToString();
            }

            return number;
        }

        public static string GenerateRandomString(int length = 5)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());
        }

        public static string GenerateRandomEmail(int length = 5)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(chars, length)
                                            .Select(s => s[random.Next(s.Length)])
                                            .ToArray());
            return $"{randomString}@gmail.com";
        }

        public static string GenerateSocialSecurityNumber()
        {
            Random random = new Random();
            string prefix = "6"; // Choose a valid starting digit: 6, 7, 8, or 9
            string number = prefix;

            for (int i = 1; i < 9; i++)
            {
                number += random.Next(0, 10).ToString();
            }

            return number;
        }

        public static string GenerateDLNumber()
        {
            Random random = new Random();
            string prefix = "6"; // Choose a valid starting digit: 6, 7, 8, or 9
            string number = prefix;

            for (int i = 1; i < 7; i++)
            {
                number += random.Next(0, 10).ToString();
            }

            return number;
        }
    }
}
