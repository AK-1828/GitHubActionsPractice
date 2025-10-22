using System;
using Reqnroll;

namespace iHaul.StepDefinitions
{
    [Binding]
    public class PaymentMethodsStepDefinitions
    {
        [When("click on payment methods")]
        public void WhenClickOnPaymentMethods()
        {
          
        }

        [When("click on add card button")]
        public void WhenClickOnAddCardButton()
        {
            throw new PendingStepException();
        }

        [When("enter card number")]
        public void WhenEnterCardNumber()
        {
            throw new PendingStepException();
        }

        [When("click on save card button")]
        public void WhenClickOnSaveCardButton()
        {
            throw new PendingStepException();
        }
    }
}
