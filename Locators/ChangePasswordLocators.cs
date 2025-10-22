
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHaul.Locators
{
    public interface ChangePasswordLocators
    {
        public static By profile = MobileBy.Id("profile_bottom_tab_item_key");
        public static By settings = MobileBy.Id("profile_list_tile_settings");
        public static By changePassword = MobileBy.AccessibilityId("Change Password");
        public static By currentPasswordInputField = MobileBy.Id("current_password");
        public static By newPasswordInputField = MobileBy.Id("new_password");
        public static By confirmNewPasswordInputField = MobileBy.Id("confirm_password");
        public static By savePasswordButton = MobileBy.Id("save_password");

    }
}
