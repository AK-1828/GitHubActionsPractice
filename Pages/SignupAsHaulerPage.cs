using iHaul.Reqnroll.Drivers;
using iHaul.Utilities;
using MobileAutomation.Assertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.BiDi.Input;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.SynchMethods;
using static iHaul.HelperClass.WaitingTime;
using static iHaul.Locators.SignupAsHaluerLocators;
using static iHaul.Locators.VerifyiHaulLoginLocators;
using static iHaul.Locators.SignupAsCustomerLocators;
using static iHaul.Reqnroll.Drivers.DriverManager;
using static iHaul.Utilities.Configure;
using static iHaul.Pages.SignupAsCustomerPage;



namespace iHaul.Pages
{
    public class SignupAsHaulerPage
    {
        private static string photoPath;
        private static string devicePhotoPath;
        public SignupAsHaulerPage() 
        {
            photoPath = Configure.Get("PhotoPath");
            devicePhotoPath  = Configure.Get("DevicePhotoPath");

        }
        public static void selectRoleAsHauler()
        {
            WaitUntilTheVerifyNoAccountPromptAndInitiateSignupNotificationIsDisappers();
            WaitUntilElementVisible(haulerRole,mediumWait);
            SafeClick(haulerRole, mediumWait);
        }

        public static void clickOnUploadPhoto()
        {

          
            WaitUntilElementVisible(uploadPhoto, mediumWait);
            SafeClick(uploadPhoto, mediumWait);
        }

        public static void clickOnUpoadFromGallery()
        {
            WaitUntilElementVisible(uploadFromGallery, mediumWait);
            SafeClick(uploadFromGallery, mediumWait);
            
        }

        public static void SelectImage()
        {
            SelectImageFromGallery(photoPath, devicePhotoPath);
        }

        public static void clickOnGalleryIcon()
        {
            WaitUntilElementVisible(myFiles, mediumWait);
            SafeClick(myFiles, mediumWait);
        }

        public static void clickOnCamera()
        {
            WaitUntilElementVisible(camera, mediumWait);
            SafeClick(camera, mediumWait);
        }

        public static void checkTheImage()
        {
            WaitUntilElementVisible(firstImage, mediumWait);
            SafeClick(firstImage, mediumWait);
        }

        public static void clickOnDone()
        {
            WaitUntilElementVisible(done, mediumWait);
            SafeClick(done, mediumWait);
        }

        public static void clickOnCrop()
        {
            WaitUntilElementVisible(cropImage, mediumWait);
            SafeClick(cropImage, mediumWait);
        }

        public static void verifySetupProfilePageIsDisplayed()
        {
           // string setupProfileText = GetElementAttribute(setupProfleText, "content-desc", longWait);
            //Console.WriteLine(setupProfileText);
            Asserts.IsTrue(WaitUntilElementVisible(setupProfleText, longWait).Displayed, "Setup Profile page is not displayed");
        }

        public static void enterSocialSecurityNumber()
        {
            string ssn = "612206832";
            //String ssn = GenerateSocialSecurityNumber();
            WaitUntilElementVisible(socialSecurityNumberInputField, longWait);
            SafeClick(socialSecurityNumberInputField, mediumWait);
            EnterText(socialSecurityNumberInputField, ssn, mediumWait);
           Driver.HideKeyboard();
        }

        public static void enterAbout(String about)
        {
            SafeClick(aboutInpiField,mediumWait);
            EnterText(aboutInpiField,about,mediumWait);
            Driver.HideKeyboard();
        }

        public static void enterAddressline1(string addressline1)
        {
            SafeClick(addressLine1InputField, mediumWait);
            EnterTextSlowly(addressLine1InputField, addressline1, mediumWait);
            Driver.HideKeyboard();
        }

      
        public static void enterAddressline2(string addressline2)
        {
            SafeClick(addressLine2InputField, mediumWait);
            EnterText(addressLine2InputField, addressline2, mediumWait);
            Driver.HideKeyboard();
        }

        public static void enterZipcode(String zipcode)
        {
            SafeClick(zipCodeInputField,mediumWait);
            EnterText(zipCodeInputField, zipcode,mediumWait);
            Driver.HideKeyboard();
        }

        public static void enterState(string state)
        {
            SafeClick(selectStateInputField,mediumWait);
            EnterText(selectStateInputField,state,mediumWait);
            Driver.HideKeyboard();

        }

        public static void selectStateAL()
        {
           
            SafeClick(selectState, mediumWait);
            Driver.HideKeyboard();
        }

        public static void enterCity(String city)
        {
            
            WaitUntilElementVisible(cityInputField, mediumWait);
            SafeClick(cityInputField, mediumWait);
            EnterText(cityInputField, city, mediumWait);
            Driver.HideKeyboard();
        }

        public static void clickOnSaveAndNext()
        {
            
            WaitUntilElementVisible(saveAndNextButton,mediumWait);
            SafeClick(saveAndNextButton, mediumWait);
            WaitUntilElementDisappears(updatingSpinner,mediumWait);
           
        }





        //Emulator methods for uploading the Photo
        public static void clickOnElipsis()
        {
            WaitUntilElementVisible(moreActions, mediumWait);
            SafeClick(moreActions, mediumWait);
        }

        public static void clickOnBrowse()
        {
            WaitUntilElementVisible(browse, mediumWait);
            SafeClick(browse, mediumWait);
        }

        public static void clickOnShowRoots()
        {
            WaitUntilElementVisible(showRoots, mediumWait);
            SafeClick(showRoots, mediumWait);
        }

        public static void clickOnDownloads()
        {
            WaitUntilElementVisible(downloads, mediumWait);
            SafeClick(downloads, mediumWait);
        }

        public static void clickonFirstImageFromDownloads()
        {
            WaitUntilElementVisible(imageFromDownloads, mediumWait);
            SafeClick(imageFromDownloads, mediumWait);
        }

        public static void enterDLIssuedBy(string dlIssuedBy)
        {
            SafeClick(dlIssuedByInputField, mediumWait);
            EnterText(dlIssuedByInputField,dlIssuedBy,mediumWait);
           // Driver.HideKeyboard();
        }

        public static void selectDLIssuedBy()
        {
            //By selectState = By.XPath($"//android.view.View[@content-desc='{dlIssuedBy}']");
            SafeClick(selectState, mediumWait);
          //  Driver.HideKeyboard();
        }

        public static void enterDLNumber()
        {
            string dlNumber = GenerateDLNumber();
            SafeClick(dlNumberInputField, mediumWait);
            EnterText(dlNumberInputField,dlNumber,mediumWait);
            Driver.HideKeyboard();
        }

        public static void clickOnDLExpiryDateField()
        {
            WaitUntilElementVisible(dlExpiryDate, mediumWait);
            SafeClick(dlExpiryDate,mediumWait);
         //   SafeClick(selectYear,mediumWait);
        }

        public static void clickOnUploadDLCopy()
        {
            WaitUntilElementVisible(dlCopy, mediumWait);
            SafeClick(dlCopy,mediumWait);
        }




    }
}
