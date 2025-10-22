Feature: EnableOrDisbaleAlertsFromCustome

Background: 
	Given click on the next button
	When enter the mobile number "akqa1828@gmail.com"
	When click on continue button
    When enter the code
	When click on ok button
	When click on profile icon
	When click on settings


Scenario: Enable bid alerts
	When click on alerts
	When enable the bid alerts toggle


Scenario: Disable bid alerts
	When click on alerts
	When disable the bid alerts toggle


Scenario: Enable haul alerts
	When click on alerts
	When enable the haul alerts toggle



Scenario: Disable haul alerts
	When click on alerts
	When disable the haul alerts toggle
	


	
