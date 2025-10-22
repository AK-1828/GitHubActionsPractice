using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

public class GmailHelper
{
    static string[] Scopes = { GmailService.Scope.GmailReadonly };
    static string ApplicationName = "Appium OTP Fetcher";



    public static string GetLatestOtp(string email, string appPassword)
    {
        using (var client = new ImapClient())
        {
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(email, appPassword);

            // Open the inbox folder
            client.Inbox.Open(FolderAccess.ReadOnly);

            // Get the most recent message
            var uids = client.Inbox.Search(SearchQuery.NotSeen.And(SearchQuery.DeliveredAfter(DateTime.Now.AddMinutes(-10))));

            if (uids.Count > 0)
            {
                var message = client.Inbox.GetMessage(uids.Last());

                // Get body (text or HTML)
                var body = message.TextBody ?? message.HtmlBody;

                if (!string.IsNullOrEmpty(body))
                {
                    // Extract 6-digit OTP
                    var match = Regex.Match(body, @"\d{6}");
                    if (match.Success)
                    {
                        client.Disconnect(true);
                        return match.Value;
                    }
                }
            }

            client.Disconnect(true);
        }
        return null;
    }

}