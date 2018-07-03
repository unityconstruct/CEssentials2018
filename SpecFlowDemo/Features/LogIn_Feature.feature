﻿Feature: LogIn_Feature
	In order to access my account
    As a user of the website
    I want to log into the website

@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the Home Page
	And Navigate to LogIn Page
	When User enter 'UnityAdmin' and 'UnityAdmin@2017'
	And Click on the LogIn button
	Then Successful LogIN message should display
	When User LogOut from the Application
	Then Successful LogOut message should display
	Then User closes browser


