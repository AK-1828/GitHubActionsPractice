Feature: SignupAsHauler

A short summary of the feature

@tag1
Scenario Outline: Signup as hauler and verify
	When click on skip button
	Then verify that "<welcome text>" is displayed
	When enter the mobile number
	When click on continue button
	When select role as Hauler
	When click on continue button
	When click on upload photo
	When click on upload from gallery
	When click on elipsis
	When click on browse
	When click on roots
	When click on downloads
	When click on first image
	When click on crop
	When enter first name
	When enter last name 
	When enter email
	When enter date of birth
	When select gender
	When enter create password "<password>"
	When enter confirm passowrd "<password>"
	When accept terms and privacy policy
	When click on signup button
	When enter the "<6-digit>" code sent to your mobile number
	When enter the code sent to your email
	When click on verify button
	Then verify "<verification successful>" message
	When click on OK 
	#When allow notification
	#When click on allow location
	#When click on while using the app
	#When click on OK
	Then verify page is displayed
	When enter social security number
	When enter about "<about text>"
	When enter addressline1 "<addressline1>"
	When enter addressline2 "<addressline2>"
	When enter zipcode "<zipcode>"
	When enter State "<state>"
	When select state
	When enter city "<city>"
	When click on save and next
	When enter DL issued by "<DL issued by>"
	When select DL issued by
	When enter DL number
	When click on dl expiry date field
	When enter DL expiry date
	When click on upload DL copy
	When click on upload from gallery
	When click on roots
	When click on downloads
	When click on first image
	When click on crop
	When click on save and next
	When enter make "<make>"
	When enter model "<model>"
	When enter year "<year>"
	When enter type "<type>"
	When enter current miles "<current miles>"
	When click on select condition dropdown
	When select condition "<condition>"
	When enter cargo capacity
	When enter vehicle lenght "<lenght>"
	When enter vehicle width "<width>"
	When enter vehicle height "<height>"
	When enter license plate "<license plate>"
	When click registered state dropdown
	When select registered state "<state>"
	When click on upload registration field
	When click on choose from files
	When click on roots
	When click on downloads
	When select the vehicle registration
	When click on upload insurance field
	When  click on choose from files
	When click on roots
	When click on downloads
	When selec the insurance
	When click on pictures button
	When click on upload from gallery
	When click on elipsis
	When click on browse
	When click on roots
	When click on downloads
	When select images to upload
	When click on save and next


	



Examples: 
	| welcome text       | verify both email and mobile phone | 6-digit | verification successful | about text | addressline1 | addressline2 | zipcode | setup profile  | state | city  | DL issued by | make | model | condition | lenght | width | height | license plate | password |
	| Welcome to i-Haul! | Verify Both Email & Mobile Phone   | 123456  | Verification Successful | Testing    | Alabama      | Testing      | 35004   | Set Up Profile | AL    | Moody | AL           | Ford | f-150 | Excellent | 20     | 10    | 12     | ABC123        | 123456   |


	
