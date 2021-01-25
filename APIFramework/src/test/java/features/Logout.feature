#Author: your.email@your.domain.com
#Keywords Summary :
#Feature: List of scenarios.
#Scenario: Business rule through list of steps with arguments.
Feature: Validating Logout
@LogoutAPI
Scenario Outline: Verify if user is being Succesfully logout using LogoutAPI
	Given Logout user with "<username>" 
	When user1 calls "Logout" with "POST" http request
	Then the API call1 got success with status code 200

Examples:
	|username 	 | 
	|CCSUserTest1@yopmail.com | 