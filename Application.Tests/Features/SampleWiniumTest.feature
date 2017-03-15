Feature: SampleWiniumTest

Scenario Outline: Add a New Customer
	When I Click Customers Tab
	And I Click Add New Customer Button
	And I Set NameandSurname as <Name>
	And I Set Address as <Address>
	And I Set PhoneNumber as <Phone>
	And I Click Save Button
	#Then the result should be 120 on the screen

	Examples: 
	| Name      | Address   | Phone  |
	| Sudarshan | Bangalore | 918095 |
