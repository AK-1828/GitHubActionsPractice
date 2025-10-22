Feature: ChangePassword

Background: 
	Given click on the next button
	When enter the mobile number "akqa1828@gmail.com"
	When click on continue button
    When enter the code
	When click on ok button

Scenario Outline: change password and verify
	When click on profile icon
	When click on settings
	When click on change password
	When enter curretn password "<current password>"
	When enter new password "<new password>"
	When enter confirm new password "<new password>"
	When click on save password button

Examples: 
| current password | new password |
| haul12345        |  new12345          |




