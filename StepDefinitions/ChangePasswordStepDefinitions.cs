using static iHaul.Pages.ChangePasswordPage;

namespace iHaul.StepDefinitions
{
    [Binding]
    public class ChangePasswordStepDefinitions
    {
        [When("click on profile icon")]
        public void WhenClickOnProfileIcon()
        {
            clickOnProfile();
        }

        [When("click on settings")]
        public void WhenClickOnSettings()
        {
            clickOnSettings();
        }

        [When("click on change password")]
        public void WhenClickOnChangePassword()
        {
           clickOnChangePassword();
        }

        [When("enter curretn password {string}")]
        public void WhenEnterCurretnPassword(string currentPassword)
        {
            enterCurrentPassword(currentPassword);
        }

        [When("enter new password {string}")]
        public void WhenEnterNewPassword(string newPassword)
        {
            enterNewPassword(newPassword);
        }

        [When("enter confirm new password {string}")]
        public void WhenEnterConfirmNewPassword(string confirmNewPassword)
        {
          enterConfirmNewPassword(confirmNewPassword);  
        }

        [When("click on save password button")]
        public void WhenClickOnSavePasswordButton()
        {
          clickOnSavePasswordButton();
        }
    }
}
