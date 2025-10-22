using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHaul.Locators
{
    public interface SignupAsHaluerLocators
    {
        public static By haulerRole => By.XPath("//android.widget.ImageView[contains(@content-desc,'Hauler')]");
        public static By uploadPhoto => MobileBy.Id("image_upload_picker_profile_picture");
        public static By uploadFromGallery => MobileBy.Id("upload_from_gallery");
        public static By takeAPhoto => MobileBy.Id("take_a_photo");
        public static By galleryIcon => MobileBy.AccessibilityId("Gallery");
        public static By cropImage => MobileBy.AccessibilityId("Crop");
        public static By camera => By.XPath("//android.widget.TextView[@text='Camera']");
        public static By myFiles => By.XPath("//android.widget.TextView[@content-desc='My Files']");
        public static By firstImage => By.XPath("(//android.widget.CheckBox[@resource-id='com.sec.android.app.myfiles:id/checkbox'])[13]");
        public static By done => MobileBy.AccessibilityId("Done");

        //Emulator locators
        public static By elipsis => By.XPath("//androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View[4]/android.widget.Button");
        public static By moreActions => MobileBy.AccessibilityId("More options");
        public static By browse =>By.XPath("//android.widget.TextView[@text='Browse…']");
        public static By imageFromDownloads => By.XPath("(//android.widget.ImageView[@resource-id='com.google.android.documentsui:id/icon_thumb'])[13]");
       // public static By downloads => By.XPath("//android.widget.TextView[@resource-id='android:id/title' and @text='Downloads']");


        //Setup Profile locators

        public static By generalInfo => MobileBy.AccessibilityId("General Info.");
        public static By setupProfleText => MobileBy.Id("mover_setup_appbar_title");

        public static By socialSecurityNumberInputField => MobileBy.Id("ssn");

        public static By aboutInpiField => MobileBy.Id("about");

        public static By addressLine1InputField => By.XPath("//android.widget.EditText[@resource-id='streetOne']/android.widget.EditText");

        public static By addressLine2InputField => MobileBy.Id("streetTwo");
        public static By zipCodeInputField => MobileBy.Id("zipCode");
        public static By selectStateInputField => MobileBy.Id("state");
        public static By selectState => MobileBy.Id("AL");
        public static By cityInputField => By.XPath("//android.view.View[@content-desc='City*']//following-sibling::android.widget.EditText");

        public static By saveAndNextButton => MobileBy.Id("save_&_next");

        public static By updatingSpinner => MobileBy.AccessibilityId("Updating...");

        public static By dlDetails => MobileBy.AccessibilityId("DL Details");
        public static By dlIssuedByInputField => MobileBy.Id("dlState");

        public static By dlNumberInputField => MobileBy.Id("dlNumber");

        public static By dlExpiryDate => MobileBy.Id("dlExpiryDate");

        public static By selectYear = By.XPath("//android.widget.Button[contains(@content-desc,'Select year')]");

        public static By dlCopy => MobileBy.Id("file_upload_box_dl_copy");

        public static By vehicleDetails => MobileBy.AccessibilityId("Vehicle Details");
        public static By makeInputField => MobileBy.Id("vehMake-e.g., Ford, Chevrolet");
        public static By modelInputField => MobileBy.Id("vehModel-e.g., F-150, Silverado");
        public static By yearInpoutField => MobileBy.Id("vehYear-e.g., 2020, 2019");
        public static By typeInputField => MobileBy.Id("vehType-e.g., Pickup, Semi-truck");
        public static By currentMilesInoutField => MobileBy.Id("currentMiles-e.g., 50,000");
        public static By selectCondition => By.XPath("//android.view.View[@content-desc='Condition*']//following-sibling::android.view.View[@content-desc='Select']");

        
        public static By conditionOption => By.XPath("//android.widget.Button[@content-desc='Excellent']");//Make this locator dynamic so that we can select other oprions like Good,Average,Poor

        public static By cargoCapacity => MobileBy.Id("vehCapacity-e.g., 5000");

        public static By vehicleSizeLengthInput => MobileBy.Id("vehLength-Length");
        public static By vehicleSizeWidhtInputField => MobileBy.Id("vehWidth-Width");
        public static By vehicleSizeHeightInputField => MobileBy.Id("vehHeight-Height");

        public static By licenssePlateInputField => MobileBy.Id("vehLicenseNumber-e.g., ABC1234");

        //public static By selectState => By.XPath("//android.view.View[@content-desc='Select state']");
     
        public static By stateName => By.XPath("//android.widget.Button[@content-desc='AK']");  //Make the this locator dynamic so that we can select other states like AL, AR etc

        public static By vehicleRegistration => MobileBy.AccessibilityId("Upload Registration\nSupported formats: JPEG, PNG, PDF");
        public static By vehicleInsurance => MobileBy.AccessibilityId("Upload Insurance\nSupported formats: JPEG, PNG, PDF");
        public static By pictures => MobileBy.AccessibilityId("Pictures* (upto 5)\nUpload front, back, left and right pictures.");
        public static By serviceArea => MobileBy.Id("serviceArea-Type address");
        public static By serviceRadiusBar => By.ClassName("android.widget.SeekBar");
        public static By cargoCapacityAtPreferences => MobileBy.Id("maxCargoCapacity-e.g., 5000");
        public static By willingnessToLiftYesRadioButton => By.XPath("(//android.view.View[@content-desc='Yes'])[1]");
        public static By willingnessToLiftNoRadioButton => By.XPath("(//android.view.View[@content-desc='No'])[1]");

        public static By weightInputField => MobileBy.Id("maxWeightToCarry-Enter max weight you're willing to lift");
        public static By willingnessToProvideAdditionalPeopleYesRadioButton => By.XPath("(//android.view.View[@content-desc='Yes'])[2]");
        public static By willingnessToProvideAdditionalPeopleNoRadioButton => By.XPath("(//android.view.View[@content-desc='No'])[2]");
        public static By numberInputField => MobileBy.Id("maxAdditionalHelp-Max additional help you can provide");
        public static By willingnessToUseStaircaeYesRadioButton => By.XPath("(//android.view.View[@content-desc='Yes'])[3]");
        public static By willingnessToUseStaircaeNoRadioButton => By.XPath("(//android.view.View[@content-desc=\"No\"])[3]");
        public static By assemblyServicesYesRadioButton => By.XPath("(//android.view.View[@content-desc='Yes'])[4]");
        public static By assemblyServicesNoRadioButton => By.XPath("(//android.view.View[@content-desc='No'])[4]");
        public static By disassemblyServicesYesRadioButton => By.XPath("(//android.view.View[@content-desc='Yes'])[5]");
        public static By disassemblyServicesNoRadioButton => By.XPath("(//android.view.View[@content-desc='No'])[5]");
        public static By downloadW9FormTemplate => MobileBy.Id("downloadCopy-w9sample.pdf");
        public static By uploadW9Form => By.XPath("Upload W9 Form\nSupported formats: JPEG, PNG, PDF");
        public static By showRoots => MobileBy.AccessibilityId("Show roots");
        public static By downloads => By.XPath("//android.widget.TextView[@resource-id='android:id/title' and @text='Downloads']");
        public static By w9SamplePdf => By.XPath("//android.widget.TextView[@resource-id='android:id/title' and @text='w9sample.pdf']");
        public static By getStarted => MobileBy.AccessibilityId("Get Started");

        public static By chooseFromFiles => By.XPath("//android.view.View[@content-desc='Choose From Files']");

        public static By licensePNG => By.XPath("//android.widget.TextView[contains(@text,'Drive license.png')]");//make it dynamic in future




        
    }
}
