Feature: CreateNewHaulRequest

Background: 
	Given click on the next button
	When enter the mobile number "akqa1828@gmail.com"
	When click on continue button
    When enter the code
	When click on ok button

Scenario Outline: Create new haul request and verify
	When click on setpickup and dropoff location button
	When enter zipcode for new Haul Request "<zipcode>"
	When click on check button
	When click on select haul type dropdown
	When select haul type
	When click on upload photos button
	When click on upload from gallery
	When click on elipsis
	When click on browse
	When click on roots
	When click on downloads
	When click on first image
	#When selec the images
	When describe the items "<describeItems>"
	When select the require packing option
	When select the require packing material option
	When select the who will handle the heavy items option
	When check the request assembly option
	When check the request disassembly option
	When enter additianl info "<additional info>"
	When click on continue button
	When click on pickup address 
	When enter the address "<pickup address>"
	When select the entered address "<pickup address>"
	When click on continue button
	When click on select address type dropdown
	When select address type 
	When enter number of floors "<number of floors>"
	When enter save address as "<address as>"
	When enter contact name "<contact name>"
	When enter contact number "<contact number>"
	When enter  building or unit number "<building number>"
	When enter apartment number "<apartment number>"
	When enter floor number "<floor number>"
	When Select elevator accessibility option
	When enter additianl info "<additional info>"
	When click on continue button
	When click on dropoff address 
	When enter the address "<dropoff address>"
	When select the entered address "<dropoff address>"
	When click on select the address type dropdown for dropoff
	When select the address type for dropoff
	When enter number of floors "<number of floors>"
	When enter save address as "<address as>"
	When enter contact name "<contact name>"
	When enter  building or unit number "<building number>"
	When enter apartment number "<apartment number>"
	When enter floor number "<floor number>"
	When Select elevator accessibility option 
	When enter additianl info "<additional info>"
	When click on continue button
	When click on pickup date field
	When selec the date "<date>"
	When click on ok
	When check the i'm flxible with date
	When enter By in days "<By in days>"
	When select the between time 
	When click on ok
	When selec the and time
	When click on ok
	When When click on continue button
	When click on choose payment method button
	When click on  add card button
	When enter card nick name "<nick name>"
	When enter card holder name "<card holder name>"
	When enter card number "<card number>"
	When enter valid thru "<valid thru>"
	When enter cvv or cvc "<cvv>"
	When click on billing is same as mailing address
	When save card button
	When select the card
	When click on submit for bids button
	When click on ok
	Then verify that awaiting bis status is displayed




 Examples: 
| pickup address                    | dropoff address                        | describeItems | additional info          | number of floors | address as | contact name | building number | apartment number | floor number | contact number | zipcode | date | By in days | nick name | card holder name | card number      | valid thru | cvv |
| 6342 Willow St, Houston, TX 77063 | 2795 Chestnut Place, Houston, TX 77041 | Testing       | Testing the Haul Details | 15               | Home       | Anji         | 11              | 12               | 13           | 7596555555555  | 35004   | 29   | 3          | anji      | Anjaneyulu       | 5555555555554444 | 10/26      | 123 |



