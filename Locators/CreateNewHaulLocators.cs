using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.DevTools.V137.HeapProfiler;


namespace iHaul.Locators
{
    public interface CreateNewHaulLocators
    {
        public static By createNewHaulText = MobileBy.AccessibilityId("Create a New Haul");////android.view.View[@content-desc="Create a New Haul"]
        public static By setPickupAndDropOffLocation = MobileBy.Id("create_haul_container_button");
        public static By zipCodeText = By.XPath("//android.view.View[@content-desc='ZIP Code']");
        public static By zipCodeInputField = MobileBy.Id("zipCode");
        public static By checkButton = MobileBy.Id("check");
        public static By newRequestText = By.XPath("//android.view.View[contains(@content-desc,'New Request')]");
        public static By haulTypeSelect = MobileBy.AccessibilityId("dropdown_move_type");
        public static By singleItemHaulType = MobileBy.Id("dropdown_item_move_type_single_item");
        public static By multipleItemsHaulType = MobileBy.Id("dropdown_item_move_type_multiple_items");
        public static By fullHouseHaulType = MobileBy.Id("dropdown_item_move_type_full_house");
        public static By otherHaulType = MobileBy.Id("dropdown_item_move_type_other");
        public static By uploadPhotosButton = MobileBy.Id("multi_image_picker_add_button");
        public static By uploadFromGallery = MobileBy.Id("upload_from_gallery");
        public static By camera = MobileBy.Id("camera");
        public static By cancel = MobileBy.Id("cancel");
        public static By describeTheItemsInputField = MobileBy.Id("itemDescription");
        public static By requirePackingYesRadioButton = MobileBy.Id("radio_option_need_packaging_yes");
        public static By requiredPackingNoRadioButton = MobileBy.Id("radio_option_need_packaging_no");
        public static By requirePackingMaterialYesRadioButton = MobileBy.Id("radio_option_need_packing_material_yes");
        public static By requiredPackingMaterialNoRadioButton = MobileBy.Id("radio_option_need_packing_material_no");
        public static By handleHeavyWeightMySelfRadioButton = MobileBy.Id("radio_option_who_lifting_me");
        public static By handleHeavyWeightHaulerRadioButton = MobileBy.Id("radio_option_who_lifting_you");
        public static By handleHeavyWeightBothRadioButton = MobileBy.Id("radio_option_who_lifting_we");
        public static By requestAssemblyPickupCheckBox = By.XPath("(//android.view.View[@content-desc='Pickup']//preceding-sibling::android.widget.CheckBox)[1]");
        public static By requestAssemblyDropoffCheckBox = By.XPath("(//android.view.View[@content-desc='Drop off']//preceding-sibling::android.widget.CheckBox)[2]");
        public static By requestDisassembyPickupCheckbox = By.XPath("(//android.view.View[@content-desc='Pickup']//preceding-sibling::android.widget.CheckBox)[2]");
        public static By requestDisassembyDropoffCheckbox = By.XPath("(//android.view.View[@content-desc='Drop off']//preceding-sibling::android.widget.CheckBox)[4]");
        public static By additionalInfoInputField = MobileBy.Id("additionalInstructions");
        public static By continueButton = MobileBy.Id("continue");
        public static By addressInputField = MobileBy.Id("address"); // for both pickup and Drop off address
        public static By searchAddressInputField = MobileBy.Id("search");
        public static By selectTheAddress = By.XPath("//android.widget.ImageView[@content-desc=\"Birch Ave\r\nStaten Island, NY\"]");//make dynamic to select the Address
        public static By selectAddressType = MobileBy.AccessibilityId("Select");
        public static By addressTypeApartmentOrCondo = MobileBy.AccessibilityId("Apartment / Condo");
        public static By adressTypeIndividualHouse = MobileBy.AccessibilityId("Individual House");
        public static By addressTypeBusiness = MobileBy.AccessibilityId("Business");
        public static By addressTypeOther = MobileBy.AccessibilityId("Other");
        public static By numberOfFloorsinputField = MobileBy.Id("numberOfFloors");
        public static By saveAddressAsinputfield = MobileBy.Id("saveAs");
        public static By contactNameInputField = MobileBy.Id("receiverName");
        public static By contactNumberInputField = MobileBy.Id("receiverMobile");
        public static By buildingNumberinputField = MobileBy.Id("buildingNumber");
        public static By apartNumberInputField = MobileBy.Id("aptNumber");
        public static By floorNumberInputField = MobileBy.Id("floorNumber");
        public static By elevatorAccessibilityYesRadioButton = MobileBy.Id("radio_floor_access_yes");
        public static By elevatorAccessibilityNoRadioButton = MobileBy.Id("radio_floor_access_no");
        public static By elevatorAccessibilityNotApplicableRadioButton = MobileBy.Id("radio_floor_access_not_applicable");
        public static By additionalInfoInputFieldAtPickupAndDropOffDetails = MobileBy.Id("instructions");
        public static By pickupDate = MobileBy.Id("pickupDate");
        public static By okButton = MobileBy.AccessibilityId("OK");
        public static By flexibleWithDate = MobileBy.Id("flexible");
        public static By byInDays = MobileBy.Id("flexibleBy");
        public static By fromTime = MobileBy.Id("fromTime");
        public static By toTime = MobileBy.Id("toTime");
        public static By selectHours = MobileBy.AccessibilityId("Select hours");
        public static By selectMinutes = MobileBy.AccessibilityId("Select minutes");
        public static By am = MobileBy.AccessibilityId("AM");
        public static By pm = MobileBy.AccessibilityId("PM");
        public static By choosePaymentMethod = MobileBy.Id("choose_payment_method");
        public static By yesFromConfirmation = MobileBy.Id("yes");
        public static By addCardButton = MobileBy.AccessibilityId("+Add Card");
        public static By nickNameInputField = MobileBy.Id("nickName");
        public static By cardHoldeNameInputField = MobileBy.Id("holderName");
        public static By cardNumberInputField = MobileBy.Id("cardNumber");
        public static By validThruInputField = MobileBy.Id("validThru");
        public static By cvvInputField = MobileBy.Id("cvv");
        public static By sameAddressCheckBox = MobileBy.Id("same_address");
        public static By saveCardButton = MobileBy.Id("save_card");
        public static By submitForBidsButton = MobileBy.Id("submit_for_bids");
        public static By cardRadioButton = By.XPath("//android.view.View[contains(@content-desc,'radio_card_selector')]");
        public static By awaitingBidsStatus = MobileBy.AccessibilityId("Status - Awaiting Bids");
        public static By zipCodeInputFieldForNewHaulRequest => MobileBy.Id("zipCode");
        public static By selectMinutesSections = By.XPath("//android.widget.SeekBar[contains(@content-desc,'Select minutes')]");



    }
}










