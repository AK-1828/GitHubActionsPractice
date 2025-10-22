Feature: Signup as Custmer


Scenario Outline: Signup As Cusomer And Verify
	When click on skip button
	Then verify that "<welcome text>" is displayed
	When enter the mobile number
	When click on continue button
	#Then "<select role>" page is displayed
	When select role
	When click on continue button
	#Then "<signup as customer>" page is displayed
	When enter first name
	When enter last name 
	When enter email
	When enter date of birth
	When select gender
	When enter create password "<password>"
	When enter confirm passowrd "<password>"
	When accept terms and privacy policy
	When click on signup button
	#Then "<verify both email and mobile phone>" page is displayed
	When enter the "<6-digit>" code sent to your mobile number
	When enter the code sent to your email
	When click on verify button
	Then verify "<verification successful>" message
	When click on OK 
	#When allow notification
	#When click on allow location
	#When click on while using the app
	When click on OK


Examples: 
| welcome text       | select role      | role     | signup as customer  | verify both email and mobile phone | 6-digit | verification successful | password |
| Welcome to i-Haul! | Select Your Role | Customer | Sign Up As Customer | Verify Both Email & Mobile Phone   | 123456  | Verification Successful | 123456   |



