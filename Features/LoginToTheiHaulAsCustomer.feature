Feature: LoginToTheiHaulAsCustomer

A short summary of the feature


Scenario Outline: Login to the i-Haul with password
	Given click on the next button
	When enter the mobile number "<email>"
	When click on continue button
	When click on use password instead
	When enter password "<password>"
    #When enter the code
	When click on login button
	When click on ok button
Examples:
	|mobile Number | email              | password   |
	|8341819195    |akqa1828@gmail.com  | 123456 |


Scenario Outline: Login to the i-Haul with otp
	Given click on the next button
	When enter the mobile number "<email>"
	When click on continue button
    When enter the code "<email>","<appPassword>"
	When click on ok button
Examples:
	| mobile Number | email              | appPassword |
	| 8341819195    | akqa1828@gmail.com | grkm xulp jtwx rpqg         |