Feature: Validating Login
@LoginAPI
Scenario Outline: Verify if user is being Succesfully login using LoginAPI
	Given Login user with "<username>"  "<password>" 
	When user calls "Login" with "POST" http request
	Then the API call got success with status code 200

Examples:
	|username 	 | password |
	|CCSUserTest1@yopmail.com |  Ccsuser@123 |



	

	
	
	
	
	
	

	
	
	