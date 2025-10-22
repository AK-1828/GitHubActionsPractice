using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.SynchMethods;
using static iHaul.HelperClass.WaitingTime;
using static iHaul.Locators.EnableOrDisbaleAlertsForCustomerLocators;

namespace iHaul.Pages
{
    public static class EnableOrDisbaleAlertsForCustomerPage
    {
        public static void clickOnAlerts()
        {
            WaitUntilElementVisible(alerts,mediumWait);
            SafeClick(alerts,mediumWait);
        }
        public static void enableBidAlerts()
        {
            bool isEnabled = bidAlertsToggle.GetAttribute("checked") == "true";

            if (!isEnabled)
            {
                bidAlertsToggle.Click(); // Turn it ON
                Console.WriteLine("Toggle was OFF, now enabled.");
            }
            else
            {
                Console.WriteLine("Toggle is already enabled.");
            }
        }

        public static void disableBidAlerts() 
        {
            bool isEnabled = bidAlertsToggle.GetAttribute("checked") == "true";

            if (isEnabled)
            {
                bidAlertsToggle.Click(); // Turn it OFF
                Console.WriteLine("Toggle was ON, now disabled.");
            }
            else
            {
                Console.WriteLine("Toggle is already disabled.");
            }
        }

        public static void enableHaulAlerts()
        {
            bool isEnabled = haulAlertsToggle.GetAttribute("checked") == "true";

            if (!isEnabled)
            {
                haulAlertsToggle.Click(); // Turn it ON
                Console.WriteLine("Toggle was OFF, now enabled.");
            }
            else
            {
                Console.WriteLine("Toggle is already enabled.");
            }
        }

        public static void disableHaulAlerts()
        {
            bool isEnabled = haulAlertsToggle.GetAttribute("checked") == "true";

            if (isEnabled)
            {
                haulAlertsToggle.Click(); // Turn it OFF
                Console.WriteLine("Toggle was ON, now disabled.");
            }
            else
            {
                Console.WriteLine("Toggle is already disabled.");
            }
        }
    }
}
