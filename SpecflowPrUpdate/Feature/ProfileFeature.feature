Feature: ProfileFeature
		Feature to add profile details
	so that My skills can be seen

@automation
Scenario: Login for Profile
Given I Navigate to the HomePage for Login
And I Click SignIn button
And I Login with Username 'deepa.nair.d@gmail.com' and Password 'Industry15Connect' on the Login Page
And I Click Login button
Then  I should login to Profile page


Scenario:  Updating the Profile Name and Availability
Given Clicked on the Profile tab
And click on Update First Name  and LastName 
And Click on availabilty tab and update availability
And click on hour tab and update working hours
And click on Ear target  tab to update the  the earning per month
And click on Add description
Then check all the fields are updated.

