using MobileAutomation.Assertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.DevTools.V137.Audits;
using System.Reflection.Emit;
using static iHaul.HelperClass.Actions;
using static iHaul.HelperClass.SynchMethods;
using static iHaul.HelperClass.WaitingTime;
using static iHaul.Locators.CreateNewHaulLocators;

namespace iHaul.Pages
{
    public class CreateNewHaulRequestPage
    {
        public CreateNewHaulRequestPage()
        {

        }

        public static void clicklickOnSetpickupAndDropoffLocationButton()
        {
            WaitUntilElementVisible(setPickupAndDropOffLocation,mediumWait);
            SafeClick(setPickupAndDropOffLocation, mediumWait);

        }

        public static void clickOnCheckButton()
        {
            WaitUntilElementVisible(checkButton,mediumWait);
            SafeClick(checkButton, mediumWait);
        }

        public static void clickOnSelectHaulTypeDropdown()
        {
            WaitUntilElementVisible(haulTypeSelect,mediumWait);
            SafeClick(haulTypeSelect,mediumWait);
        }

        public static void clickOnSingleItemHaulType()
        {
            WaitUntilElementVisible(singleItemHaulType, mediumWait);
            SafeClick(singleItemHaulType, mediumWait);
        }
         public static void clickOnMultipleItemsHaulType()
        {
            WaitUntilElementVisible(multipleItemsHaulType, mediumWait);
            SafeClick(multipleItemsHaulType, mediumWait);
        }

        public static void clickOnFullHouseHaulType()
        {
            WaitUntilElementVisible(fullHouseHaulType, mediumWait);
            SafeClick(fullHouseHaulType, mediumWait);
        }
        public static void clickOnOtherHaulType()
        {
            WaitUntilElementVisible(otherHaulType, mediumWait);
            SafeClick(otherHaulType, mediumWait);
        }

        public static void clickOnUplodPhtosButton()
        {
            WaitUntilElementVisible(uploadPhotosButton, mediumWait);
            SafeClick(uploadPhotosButton, mediumWait);
        }

      public static void describeTheItems(String descItem)
        {
            SafeClick(describeTheItemsInputField,mediumWait);
            EnterText(describeTheItemsInputField, descItem, mediumWait);
            SafeHideKeyboard();
        }

        public static void selectRequirePackingYesRadioButton()
        {
            WaitUntilElementVisible(requirePackingYesRadioButton,mediumWait);
            SafeClick(requirePackingYesRadioButton,mediumWait);
        }

        public static void selectRequirePackingNoRadioButton()
        {
            WaitUntilElementVisible(requiredPackingNoRadioButton, mediumWait);
            SafeClick(requiredPackingNoRadioButton, mediumWait);
        }

        public static void selectRequirePackingMaterialYesRadioButton()
        {

            WaitUntilElementVisible(requirePackingMaterialYesRadioButton, mediumWait);
            SafeClick(requirePackingMaterialYesRadioButton, mediumWait);
        }

        public static void selectRequirePackingMaterialNoRadioButton()
        {

            WaitUntilElementVisible(requiredPackingMaterialNoRadioButton, mediumWait);
            SafeClick(requiredPackingMaterialNoRadioButton, mediumWait);
        }

        public static void selectMySelfRadioButtonFromWhoWillHandleTheHaeavyItemsOptions()
        {
            WaitUntilElementVisible(handleHeavyWeightMySelfRadioButton, mediumWait);
            SafeClick(handleHeavyWeightMySelfRadioButton, mediumWait);
        }

        public static void selectHaulerRadioButtonFromWhoWillHandleTheHaeavyItemsOptions()
        {
            WaitUntilElementVisible(handleHeavyWeightHaulerRadioButton, mediumWait);
            SafeClick(handleHeavyWeightHaulerRadioButton, mediumWait);

        }

        public static void selectBothRadioButtonFromWhoWillHandleTheHaeavyItemsOptions()
        {
            WaitUntilElementVisible(handleHeavyWeightBothRadioButton, mediumWait);
            SafeClick(handleHeavyWeightBothRadioButton, mediumWait);
        }

        public static void checkPickupFromRequestAssemblyOption()
        {
            WaitUntilElementVisible(requestAssemblyPickupCheckBox,mediumWait);
            SafeClick(requestAssemblyPickupCheckBox,mediumWait);
        }

        public static void checkDropOffFromRequestAssemblyOption()
        {

            WaitUntilElementVisible(requestAssemblyDropoffCheckBox, mediumWait);
            SafeClick(requestAssemblyDropoffCheckBox, mediumWait);

        }

        public static void checkPickupFromRequestDisAssemblyOption()
        {
            WaitUntilElementVisible(requestDisassembyPickupCheckbox, mediumWait);
            SafeClick(requestDisassembyPickupCheckbox, mediumWait);
        }

        public static void checkDropoffFromRequestDisAssemblyOption()
        {
            WaitUntilElementVisible(requestDisassembyDropoffCheckbox, mediumWait);
            SafeClick(requestDisassembyDropoffCheckbox, mediumWait);
        }

        public static void enterAdditionalInfo(String additionalInfo)
        {
            WaitUntilElementVisible(additionalInfoInputField,mediumWait);
            SafeClick(additionalInfoInputField, mediumWait);
            EnterText(additionalInfoInputField, additionalInfo, mediumWait);
            SafeHideKeyboard();
        }

        public static void clickOnPickUpAddressField()
        {
            WaitUntilElementVisible(addressInputField, mediumWait);
            SafeClick(addressInputField, mediumWait);
        }

        public static void enterhAddress(String address)
        {
            WaitUntilElementVisible(searchAddressInputField, mediumWait);
            SafeClick(searchAddressInputField, mediumWait);
            EnterText(searchAddressInputField, address,mediumWait);
            SafeHideKeyboard();
        }

        public static void selectTheEnteredAddress(String address) 
        {
            By selectTheAddress = By.XPath($"//android.widget.ImageView[contains(@content-desc='{address}')]");//make dynamic to select the Address
            WaitUntilElementVisible(selectTheAddress, mediumWait);
            SafeClick(selectTheAddress, mediumWait);

        }

        public static void clickOnSelectAddressTypeDropdown()
        {
            WaitUntilElementVisible(selectAddressType, mediumWait);
            SafeClick(selectAddressType, mediumWait);

        }

        public static void selectApartmentOrCondoAsAddressType()
        {
            WaitUntilElementVisible(addressTypeApartmentOrCondo, mediumWait);
            SafeClick(addressTypeApartmentOrCondo, mediumWait);
        }

        public static void selectIndividualHouseAsAddressType()
        {
            WaitUntilElementVisible(adressTypeIndividualHouse, mediumWait);
            SafeClick(adressTypeIndividualHouse, mediumWait);
        }

        public static void selectBusinessAsAddressType()
        {
            WaitUntilElementVisible(addressTypeBusiness, mediumWait);
            SafeClick(addressTypeBusiness, mediumWait);
        }
        public static void enterNumberOfFloors(String numberOfFloors)
        {
            WaitUntilElementVisible(numberOfFloorsinputField, mediumWait);
            SafeClick(numberOfFloorsinputField, mediumWait);
            EnterText(numberOfFloorsinputField,numberOfFloors, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterSaveAddressAs(String addressAs)
        {
            WaitUntilElementVisible(saveAddressAsinputfield, mediumWait);
            SafeClick(saveAddressAsinputfield, mediumWait);
            EnterText(saveAddressAsinputfield, addressAs, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterContactname(String contactName)
        {
            WaitUntilElementVisible(contactNameInputField, mediumWait);
            SafeClick(contactNameInputField, mediumWait);
            EnterText(contactNameInputField, contactName, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterBuildingOrUnit(String buildingOrUnitNumber)
        {
            WaitUntilElementVisible(buildingNumberinputField, mediumWait);
            SafeClick(buildingNumberinputField, mediumWait);
            EnterText(buildingNumberinputField, buildingOrUnitNumber, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterAprtmentNumber(String apartmentNumber)
        {
            WaitUntilElementVisible(apartNumberInputField, mediumWait);
            SafeClick(apartNumberInputField, mediumWait);
            EnterText(apartNumberInputField, apartmentNumber, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterFloorNumber(String floorNumber)
        {
            WaitUntilElementVisible(floorNumberInputField, mediumWait);
            SafeClick(floorNumberInputField, mediumWait);
            EnterText(floorNumberInputField, floorNumber, mediumWait);
            SafeHideKeyboard();
        }

        public static void selectElevatorAccessibiltyYesRadioButton()
        {
            WaitUntilElementVisible(elevatorAccessibilityYesRadioButton, mediumWait);
            SafeClick(elevatorAccessibilityYesRadioButton, mediumWait);
            SafeClick(yesFromConfirmation, mediumWait);
            
        }

        public static void selectElevatorAccessibiltyNoRadioButton()
        {
            WaitUntilElementVisible(elevatorAccessibilityNoRadioButton, mediumWait);
            SafeClick(elevatorAccessibilityNoRadioButton, mediumWait);
          
        }

        public static void selectElevatorAccessibiltyNotApplicableRadioButton()
        {
            WaitUntilElementVisible(elevatorAccessibilityNotApplicableRadioButton, mediumWait);
            SafeClick(elevatorAccessibilityNotApplicableRadioButton, mediumWait);
        }

        public static void clickOnDropoffAddressField()
        {
            WaitUntilElementVisible(addressInputField, mediumWait);
            SafeClick(addressInputField, mediumWait);
        }
        public static void enterZipCodeForNewHaulRequest(String zipCode)
        {
            WaitUntilElementVisible(zipCodeInputFieldForNewHaulRequest,mediumWait);
            SafeClick(zipCodeInputFieldForNewHaulRequest, mediumWait);
            EnterText(zipCodeInputFieldForNewHaulRequest, zipCode, mediumWait);
            SafeHideKeyboard();
            

        }

        public static void clicklickOnPickupDateField()
        {

            WaitUntilElementVisible(pickupDate, mediumWait);
            SafeClick(zipCodeInputFieldForNewHaulRequest, mediumWait);
           
        }

        public static void selectTheDate(String date)
        {
            By dateField = By.XPath($"//android.widget.Button[contains(@content-desc, '{date}')]");
            SafeClick(dateField, mediumWait);
        }

        public static void clickOnOk()
        {

            WaitUntilElementVisible(okButton, mediumWait);
            SafeClick(okButton, mediumWait);
        }

        public static void clickOnIamFlexibleCheckBox() 
        {
            WaitUntilElementVisible(flexibleWithDate, mediumWait);
            SafeClick(flexibleWithDate, mediumWait);

        }

        public static void enterByInDays(string days)
        {
            WaitUntilElementVisible(byInDays, mediumWait);
            SafeClick(byInDays, mediumWait);
            EnterText(byInDays,days, mediumWait);
            SafeHideKeyboard();
        }

        public static void clicklickOnBetweenTime()
        {
            WaitUntilElementVisible(fromTime, mediumWait);
            SafeClick(fromTime, mediumWait);
        }

        public static void selectTheHours()
        {
            WaitUntilElementVisible(selectHours, mediumWait);
            MoveClockHand (selectHours,mediumWait);

        }

        public static void clicklickOnAndTime()
        {
            WaitUntilElementVisible(toTime, mediumWait);
            SafeClick(toTime, mediumWait);
        }

        public static void clickOnMinutesSection()
        {

            WaitUntilElementVisible(selectMinutesSections, mediumWait);
            SafeClick(selectMinutesSections, mediumWait);
        }

        public static void selectTheMinutes()
        {
            WaitUntilElementVisible(selectMinutes, mediumWait);
            MoveClockHand(selectMinutes, mediumWait);

        }

        public static void clickOnContinueButton()
        {
            WaitUntilElementVisible(selectMinutesSections, mediumWait);
            SafeClick(selectMinutesSections, mediumWait);
        }

        public static void clickOnChoosePaymentMethodButton()
        {
            WaitUntilElementVisible(choosePaymentMethod, mediumWait);
            SafeClick(choosePaymentMethod, mediumWait);
        }

        public static void clickOnAddCardButton()
        {
            WaitUntilElementVisible(addCardButton, mediumWait);
            SafeClick(addCardButton, mediumWait);
        }

        public static void enterNickName(string nickName)
        {
            WaitUntilElementVisible(nickNameInputField, mediumWait);
            SafeClick(nickNameInputField, mediumWait);
            EnterText(nickNameInputField, nickName, mediumWait);
            SafeHideKeyboard();

        }

        public static void enterCardHoilderName(string cardHolderName)
        {
            WaitUntilElementVisible(cardHoldeNameInputField, mediumWait);
            SafeClick(cardHoldeNameInputField, mediumWait);
            EnterText(cardHoldeNameInputField, cardHolderName, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterCardNumber(string cardHolderName)
        {
            WaitUntilElementVisible(cardNumberInputField, mediumWait);
            SafeClick(cardNumberInputField, mediumWait);
            EnterText(cardNumberInputField, cardHolderName, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterValidThru(string validThru)
        {
            WaitUntilElementVisible(validThruInputField, mediumWait);
            SafeClick(validThruInputField, mediumWait);
            EnterText(validThruInputField, validThru, mediumWait);
            SafeHideKeyboard();
        }

        public static void enterCVV(string cvv)
        {
            WaitUntilElementVisible(cvvInputField, mediumWait);
            SafeClick(cvvInputField, mediumWait);
            EnterText(cvvInputField, cvv, mediumWait);
            SafeHideKeyboard();
        }

        public static void checkTheBillingAsSameAsMailingAddess()
        {
            WaitUntilElementVisible(sameAddressCheckBox, mediumWait);
            SafeClick(sameAddressCheckBox, mediumWait);
        }

        public static void clickOnSaveCardButton()
        {
            WaitUntilElementVisible(saveCardButton, mediumWait);
            SafeClick(saveCardButton, mediumWait);
        }

        public static void selectTheCard()
        {
            WaitUntilElementVisible(cardRadioButton, mediumWait);
            SafeClick(cardRadioButton, mediumWait);
        }

        public static void clickOnSubmitForBids()
        {
            WaitUntilElementVisible(submitForBidsButton, mediumWait);
            SafeClick(submitForBidsButton, mediumWait);    
        }

        public static void enterContactNumber(string contactNumber)
        {
            WaitUntilElementVisible(contactNumberInputField, mediumWait);
            SafeClick(contactNumberInputField, mediumWait);
            EnterText(contactNumberInputField, contactNumber, mediumWait);
            SafeHideKeyboard();
        }

        public static void verifyThatAwaitingBidsStatusIsDisplayed()
        {
            
            Asserts.IsTrue(WaitUntilElementVisible(awaitingBidsStatus, mediumWait).Displayed, "awaiting bids status is not displayed");
        }


    }
}
