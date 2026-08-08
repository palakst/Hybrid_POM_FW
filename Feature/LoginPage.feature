Feature: LoginPage

Background: 
Given browser is launched
And application is open
And user is on landing page

Scenario: Test to Validate login with correct credentials
	When the user enters valid 'user1' and 'password'
	And clicks on the login button
	Then the user should be logged in successfully

Scenario: Test to Validate login with incorrect credentials
	When the user enters invalid 'user1' and 'incorrect_password'
	And clicks on the login button
	Then the user should see an error message indicating invalid login credentials




