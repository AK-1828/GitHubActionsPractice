Feature: PaymentMethods

Background: 
	Given click on the next button
	When enter the mobile number "akqa1828@gmail.com"
	When click on continue button
    When enter the code
	When click on ok button
	When click on profile icon
	When click on settings


#Scenario Outline: add credit and debit card
	When click on payment methods
	When click on add card button
	When enter card nick name "<nick name>"
	When enter card holder name "<card holder name>"
	When enter card number 
	When enter valid thru "<valid thru>"
	When enter cvv or cvc "<cvv>"
	When click on billing is same as mailing address
	When click on save card button

#Examples: 





