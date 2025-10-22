using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.WaitingTime;
using static iHaul.HelperClass.SynchMethods;
using static iHaul.Locators.ChangePasswordLocators;


namespace iHaul.Pages
{
    public static class ChangePasswordPage
    {
        public static void clickOnProfile()
        {
            WaitUntilElementVisible(profile,mediumWait);
            SafeClick(profile,mediumWait);  
        }

        public static void clickOnSettings()
        {
            WaitUntilElementVisible(settings, mediumWait);
            SafeClick(settings, mediumWait);
        }

        public static void clickOnChangePassword()
        {
            WaitUntilElementVisible(changePassword, mediumWait);
            SafeClick(changePassword, mediumWait);
        }

        public static void enterCurrentPassword(string currentPassword)
        {
            WaitUntilElementVisible(currentPasswordInputField, mediumWait);
            SafeClick(currentPasswordInputField, mediumWait);
            EnterText(currentPasswordInputField, currentPassword, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterNewPassword(string newPassword)
        {
            WaitUntilElementVisible(newPasswordInputField, mediumWait);
            SafeClick(newPasswordInputField, mediumWait);
            EnterText(newPasswordInputField, newPassword, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterConfirmNewPassword(string confirmNewPassword)
        {
            WaitUntilElementVisible(confirmNewPasswordInputField, mediumWait);
            SafeClick(confirmNewPasswordInputField, mediumWait);
            EnterText(confirmNewPasswordInputField, confirmNewPassword, mediumWait);
            SafeHideKeyboard();
        }

        public static void clickOnSavePasswordButton()
        {
            WaitUntilElementVisible(savePasswordButton, mediumWait);
            SafeClick(savePasswordButton, mediumWait);
        }


    }
}
