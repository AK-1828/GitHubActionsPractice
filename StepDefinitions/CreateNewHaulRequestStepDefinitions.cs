using static iHaul.Pages.CreateNewHaulRequestPage;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace iHaul.StepDefinitions
{
    [Binding]
    public class CreateNewHaulRequestStepDefinitions
    {
        [When("click on setpickup and dropoff location button")]
        public void ClickOnSetpickupAndDropoffLocationButton()
        {
            clicklickOnSetpickupAndDropoffLocationButton();
        }

        [When("click on check button")]
        public void WhenClickOnCheckButton()
        {
            clickOnCheckButton();
        }

        [When("click on select haul type dropdown")]
        public void WhenClickOnSelectHaulTypeDropdown()
        {
            clickOnSelectHaulTypeDropdown();
        }

        [When("select haul type")]
        public void WhenSelectHaulType()
        {
            clickOnSingleItemHaulType();
        }

        [When("click on upload photos button")]
        public void WhenClickOnUploadPhotosButton()
        {
            clickOnUplodPhtosButton();
        }

        [When("click on showroots")]
        public void WhenClickOnShowroots()
        {
            throw new PendingStepException();
        }

        [When("selec the images")]
        public void WhenSelecTheImages()
        {
            throw new PendingStepException();
        }

        [When("describe the items {string}")]
        public void WhenDescribeTheItems(string describeItems)
        {
            describeTheItems(describeItems);
        }

        [When("select the require packing option")]
        public void WhenSelectTheRequirePackingOption()
        {
          selectRequirePackingYesRadioButton();
        }

        [When("select the require packing material option")]
        public void WhenSelectTheRequirePackingMaterialOption()
        {
            selectRequirePackingMaterialYesRadioButton();
        }

        [When("select the who will handle the heavy items option")]
        public void WhenSelectTheWhoWillHandleTheHeavyItemsOption()
        {
            selectMySelfRadioButtonFromWhoWillHandleTheHaeavyItemsOptions();
        }

        [When("check the request assembly option")]
        public void WhenCheckTheRequestAssemblyOption()
        {
            checkPickupFromRequestAssemblyOption();
        }

        [When("check the request disassembly option")]
        public void WhenCheckTheRequestDisassemblyOption()
        {
            checkPickupFromRequestDisAssemblyOption();
        }

        [When("enter additianl info {string}")]
        public void WhenEnterAdditianlInfo(string addInfo)
        {
            enterAdditionalInfo(addInfo);
        }

        [When("click on pickup address")]
        public void WhenClickOnPickupAddress()
        {
            clickOnPickUpAddressField();
        }

        [When("enter the address {string}")]
        public void WhenEnterTheAddress(string address)
        {
            enterhAddress(address);
        }

        [When("select the entered address {string}")]
        public void WhenSelectTheEnteredAddress(string address)
        {
            selectTheEnteredAddress(address);
        }

        [When("click on select address type dropdown")]
        public void WhenClickOnSelectAddressTypeDropdown()
        {
           clickOnSelectAddressTypeDropdown();
        }

        [When("select address type")]
        public void WhenSelectAddressType()
        {
            selectApartmentOrCondoAsAddressType();
        }

        [When("enter number of floors {string}")]
        public void WhenEnterNumberOfFloors(string numberOfFloors)
        {
            enterNumberOfFloors(numberOfFloors);
        }

        [When("enter save address as {string}")]
        public void WhenEnterSaveAddressAs(string addressAs)
        {
            enterSaveAddressAs(addressAs);  
        }

        [When("enter contact name {string}")]
        public void WhenEnterContactName(string contactName)
        {
            enterContactname(contactName);
        }

        [When("enter  building or unit number {string}")]
        public void WhenEnterBuildingOrUnitNumber(string buildingOrUnit)
        {
            enterBuildingOrUnit(buildingOrUnit);
        }

        [When("enter apartment number {string}")]
        public void WhenEnterApartmentNumber(string apartmentNumber)
        {
            enterAprtmentNumber(apartmentNumber);
        }

        [When("enter floor number {string}")]
        public void WhenEnterFloorNumber(string floorNumber)
        {
            enterNumberOfFloors(floorNumber);
        }

        [When("Select elevator accessibility option")]
        public void WhenSelectElevatorAccessibilityOptionClickOnYesFromTheConfirmationPopup()
        {
            selectElevatorAccessibiltyYesRadioButton();
        }

        [When("click on dropoff address")]
        public void WhenClickOnDropoffAddress()
        {
            clickOnDropoffAddressField();
        }

        [When("click on select the address type dropdown for dropoff")]
        public void WhenClickOnSelectTheAddressTypeForDropoff()
        {
            clickOnSelectAddressTypeDropdown();
        }

        [When("select the address type for dropoff")]
        public void WhenSelectTheAddressTypeForDropoff()
        {
            selectApartmentOrCondoAsAddressType();
        }

        [When("click on pickup date field")]
        public void WhenClickOnPickupDateField()
        {
            clicklickOnPickupDateField();
        }

        [When("selec the date {string}")]
        public void WhenSelecTheDate(string date)
        {
            selectTheDate(date);
        }

        [When("click on ok")]
        public void WhenClickOnOk()
        {
            clickOnOk();
        }

        [When("check the i'm flxible with date")]
        public void WhenCheckTheImFlxibleWithDate()
        {
            clickOnIamFlexibleCheckBox();
        }

        [When("enter By in days {string}")]
        public void WhenEnterByInDays(string days)
        {
            enterByInDays(days);
        }

        [When("select the between time")]
        public void WhenSelectTheBetweenTime()
        {
            clicklickOnBetweenTime();
            selectTheHours();
            clickOnMinutesSection();
            selectTheMinutes();
          

        }

        [When("selec the and time")]
        public void WhenSelecTheAndTime()
        {
            clicklickOnBetweenTime();
            selectTheHours();
            clickOnMinutesSection();
            selectTheMinutes();
           
        }

        [When("When click on continue button")]
        public void WhenWhenClickOnContinueButton()
        {
            clickOnContinueButton();
        }

        [When("click on choose payment method button")]
        public void WhenClickOnChoosePaymentMethodButton()
        {
            clickOnChoosePaymentMethodButton();
        }

        [When("click on  add card button")]
        public void WhenClickOnAddCardButton()
        {
            clickOnAddCardButton();
        }

        [When("enter card nick name {string}")]
        public void WhenEnterCardNickName(string nickName)
        {
            enterNickName(nickName);
        }

        [When("enter card holder name {string}")]
        public void WhenEnterCardHolderName(string cardHolderName)
        {
            enterCardHoilderName(cardHolderName);
        }

        [When("enter card number {string}")]
        public void WhenEnterCardNumber(string cardnumber)
        {
            enterCardNumber(cardnumber);
        }

        [When("enter valid thru {string}")]
        public void WhenEnterValidThru(string validThru)
        {
            enterValidThru(validThru);
        }

        [When("enter cvv or cvc {string}")]
        public void WhenEnterCvvOrCvc(string cvv)
        {
            enterCVV(cvv);
        }

        [When("click on billing is same as mailing address")]
        public void WhenClickOnBillingIsSameAsMailingAddress()
        {
          checkTheBillingAsSameAsMailingAddess();
        }

        [When("save card button")]
        public void WhenSaveCardButton()
        {
            clickOnSaveCardButton();
        }

        [When("select the card")]
        public void WhenSelectTheCard()
        {
            selectTheCard();
        }

        [When("click on submit for bids button")]
        public void WhenClickOnSubmitForBidsButton()
        {
           clickOnSubmitForBids();
        }

        [When("enter zipcode for new Haul Request {string}")]
        public void WhenEnterZipcodeForNewHaulRequest(string zipCode)
        {
            enterZipCodeForNewHaulRequest(zipCode);
        }

        [When("enter contact number {string}")]
        public void WhenEnterContactNumber(string contactNumber)
        {
            enterContactNumber(contactNumber);
        }
        [Then("verify that awaiting bis status is displayed")]
        public void ThenVerifyThatAwaitingBisStatusIsDisplayed()
        {
            verifyThatAwaitingBidsStatusIsDisplayed();
          
        }

       
    }
}
