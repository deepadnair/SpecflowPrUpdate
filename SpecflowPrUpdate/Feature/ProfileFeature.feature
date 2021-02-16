Feature: ProfileFeature
		Feature to add profile details
	so that My skills can be seen

@automation
Scenario: 1 Login for Profile
Given I Navigate to the HomePage for Login
And  I Click SignIn link
And I Login with Username 'deepa.nair.d@gmail.com' and Password 'Industry15Connect' on the Login Page
And I Click SignIn button to signIn to profile Page

Scenario:2  Updating the Profile Name and Availability
Given Clicking on the Profile tab
And Update First Name 'divya'  and LastName  'Kumar'
And update availability using availabilty tab 
And use hour tab and update working hours
And Use Ear target  tab to update the  the earning per month
And Use on Add description

Scenario Outline: 3  Skills Update
Given I Click on the Skills Tab and Click Add Button
And  I add the skills and level and update
    | AddSkill       |
    | manualTest     |
    | AutomationTest |
    | SAPTechnical   |
 And Check for delete function





