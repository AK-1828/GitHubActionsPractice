using mailslurp.Api;
using mailslurp.Client;
using mailslurp.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace iHaul.HelperClass
{
    public static class MailSlurpHelper
    {
        private static Configuration _config;
        private static InboxControllerApi _inboxControllerApi;
        private static WaitForControllerApi _waitForControllerApi;

            // Call this once before using other methods
            public static void Initialize(string apiKey)
            {
                _config = new Configuration();
                _config.ApiKey.Add("x-api-key", apiKey);

                _inboxControllerApi = new InboxControllerApi(_config);
                _waitForControllerApi = new WaitForControllerApi(_config);
            }

            // Create new inbox (use shared config!)
            public static InboxDto CreateNewInbox()
            {
                try
                {
                    InboxDto inbox = _inboxControllerApi.CreateInbox();
                    Console.WriteLine($"📥 Created inbox with ID: {inbox.Id} and email: {inbox.EmailAddress}");
                    return inbox;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error creating inbox: {ex.Message}");
                    return null;
                }
            }

            // Wait for latest email
            public static Email WaitForLatestEmail(Guid inboxId, long timeoutMillis = 30000)
            {
                return _waitForControllerApi.WaitForLatestEmail(inboxId, timeoutMillis);
            }

            // Extract OTP from email
            public static string ExtractOtpFromBody(string body)
            {
                var match = Regex.Match(body, @"\b\d{6}\b");
                return match.Success ? match.Value : null;
            }
    }
}
