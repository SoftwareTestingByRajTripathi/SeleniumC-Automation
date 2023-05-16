Feature: Verify OrangeCRM Loginpage 

Scenario: Verify login with vailid credentials
	Given OrangeCRM Login url
	When User entered credentials
	Then User clicks on Login button
	Then User sucessfully login the application