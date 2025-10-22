using static iHaul.Pages.SignupAsHaulerPage;
using static iHaul.Pages.SignupAsCustomerPage;

namespace iHaul.StepDefinitions
{
    [Binding]
    public class SignupAsHaulerStepDefinitions
    {
        [When("select role as Hauler")]
        public void SelectRoleAsHauler()
        {
            selectRoleAsHauler();
        }

        [When("upload the photo")]
        public void UploadThePhoto()
        {
            checkTheImage();
            clickOnDone();
           // clickOnCrop();
        }
        [When("click on elipsis")]
        public void WhenClickOnElipsis()
        {
            clickOnElipsis();
        }

        [When("click on browse")]
        public void ClickOnBrowse()
        {
            clickOnBrowse();
        }


        [When("click on upload photo")]
        public void ClickOnUploadPhoto()
        {
            clickOnUploadPhoto();
        }

        [When("click on upload from gallery")]
        public void ClickOnUploadFromGallery()
        {
            clickOnUpoadFromGallery();
        }


        [When("click on roots")]
        public void ClickOnRoots()
        {
            clickOnShowRoots();
        }

        [When("click on downloads")]
        public void ClickOnDownloads()
        {
            clickOnDownloads();
        }

        [When("click on first image")]
        public void ClickOnFirstImage()
        {
            clickonFirstImageFromDownloads();
        }

        [When("click on crop")]
        public void ClickOnCrop()
        {
            clickOnDone();
           // clickOnCrop();
        }



        [When("click on gallery icon")]
        public void ClickOnGalleryIcon()
        {
           
        }

        [When("click on camera")]
        public void ClickOnCamera()
        {
            clickOnCamera();    

        }

        [Then("verify page is displayed")]
        public void ThenVerifyPageIsDisplayed()
        {
            verifySetupProfilePageIsDisplayed();
        }


        [When("enter social security number")]
        public void EnterSocialSecurityNumber()
        {
            enterSocialSecurityNumber();
        }

        [When("enter about {string}")]
        public void EnterAbout(string about)
        {
            enterAbout(about);
        }

        [When("enter addressline1 {string}")]
        public void EnterAdressline1(string addressline1)
        {
            enterAddressline1(addressline1);
        }

        [When("selec the addressline  {string}")]
        public void SelecTheAddressline(string alabama)
        {
           
        }


        [When("enter addressline2 {string}")]
        public void EnterAddressline2(string addressline2)
        {
            enterAddressline2(addressline2);
        }

        [When("enter zipcode {string}")]
        public void EnterZipcode(string zipcode)
        {
            enterZipcode(zipcode);
        }

        [When("enter State {string}")]
        public void EnterState(string state)
        {
            enterState(state);

        }

        [When("select state")]
        public void SelectState()
        {
                   selectStateAL();
        }

        [When("enter city {string}")]
        public void EnterCity(String city)
        {
            enterCity(city);
        }

        [When("click on save and next")]
        public void ClickOnSaveAndNext()
        {
            clickOnSaveAndNext();
        }

        [When("enter DL issued by {string}")]
        public void EnterDLIssuedBy(string dlIssudeBy)
        {
            enterDLIssuedBy(dlIssudeBy);
        }


        [When("select DL issued by")]
        public void SelectDLIssuedBy()
        {
            selectDLIssuedBy();
        }

        [When("enter DL number")]
        public void EnterDLNumber()
        {
            enterDLNumber();
        }

        [When("click on dl expiry date field")]
        public void WhenClickOnDlExpiryDateField()
        {
            clickOnDLExpiryDateField();
        }

        [When("enter DL expiry date")]
        public void WhenEnterDLExpiryDate()
        {
            
            ScrollToAndSelectYear("1996");
            selectTheDate("September 29");
            clickOnOK();
        }

        [When("click on upload DL copy")]
        public void WhenClickOnUploadDLCopy()
        {
            clickOnUploadDLCopy();
        }


        [When("enter make {string}")]
        public void WhenEnterMake(string ford)
        {
            throw new PendingStepException();
        }

        [When("enter model {string}")]
        public void WhenEnterModel(string p0)
        {
            throw new PendingStepException();
        }

        [When("enter year {string}")]
        public void WhenEnterYear(string year)
        {
            throw new PendingStepException();
        }

        [When("enter type {string}")]
        public void WhenEnterType(string type)
        {
            throw new PendingStepException();
        }

        [When("enter current miles {string}")]
        public void WhenEnterCurrentMiles(string p0)
        {
            throw new PendingStepException();
        }

        [When("click on select condition dropdown")]
        public void WhenClickOnSelectConditionDropdown()
        {
            throw new PendingStepException();
        }

        [When("select condition {string}")]
        public void WhenSelectCondition(string excellent)
        {
            throw new PendingStepException();
        }

        [When("enter cargo capacity")]
        public void WhenEnterCargoCapacity()
        {
            throw new PendingStepException();
        }

        [When("enter vehicle lenght {string}")]
        public void WhenEnterVehicleLenght(string p0)
        {
            throw new PendingStepException();
        }

        [When("enter vehicle width {string}")]
        public void WhenEnterVehicleWidth(string p0)
        {
            throw new PendingStepException();
        }

        [When("enter vehicle height {string}")]
        public void WhenEnterVehicleHeight(string p0)
        {
            throw new PendingStepException();
        }

        [When("enter license plate {string}")]
        public void WhenEnterLicensePlate(string p0)
        {
            throw new PendingStepException();
        }

        [When("click registered state dropdown")]
        public void WhenClickRegisteredStateDropdown()
        {
            throw new PendingStepException();
        }

        [When("select registered state {string}")]
        public void WhenSelectRegisteredState(string aL)
        {
            throw new PendingStepException();
        }

        [When("click on upload registration field")]
        public void WhenClickOnUploadRegistrationField()
        {
            throw new PendingStepException();
        }

        [When("click on choose from files")]
        public void WhenClickOnChooseFromFiles()
        {
            throw new PendingStepException();
        }

        [When("select the vehicle registration")]
        public void WhenSelectTheVehicleRegistration()
        {
            throw new PendingStepException();
        }

        [When("click on upload insurance field")]
        public void WhenClickOnUploadInsuranceField()
        {
            throw new PendingStepException();
        }

        [When("selec the insurance")]
        public void WhenSelecTheInsurance()
        {
            throw new PendingStepException();
        }

        [When("click on pictures button")]
        public void WhenClickOnPicturesButton()
        {
            throw new PendingStepException();
        }

        [When("select images to upload")]
        public void WhenSelectImagesToUpload()
        {
            throw new PendingStepException();
        }



    }
}
