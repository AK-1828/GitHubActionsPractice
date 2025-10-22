Feature: LoginToTheiHaulAsHauler



Scenario Outline: Login to the i-Haul and verify
	Given click on the next button
	When enter the mobile number "<email>"
	When click on continue button
    When click on use password instead
	When enter password "<password>"
    #When enter the code
	When click on login button
	
Examples:
 | email                 |
 |akhauler001@gmail.com  | 



Scenario Outline: Login to the i-Haul with otp
	Given click on the next button
	When enter the mobile number "<email>"
	When click on continue button
    When enter the code "<email>","<appPassword>"
	
Examples:
	| email                 | appPassword         |
	| akhauler001@gmail.com | vmbz jupp koin mflm |