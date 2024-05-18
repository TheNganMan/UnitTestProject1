Feature: Feature1



@tag1
Scenario: Verify that as a user I can search product on e-commerce website
	Given amazon webpage is loaded
	When user click dismiss button
	And a user clicks in search bar 
	And a user fills in search box with iphone
	And a user clicks on search button
	Then all apple iphone products will be displayed
