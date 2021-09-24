Feature: Login SauceDemo
	Login for SauceDemo app

Scenario: Login sucessful
	Given Juan is on SauceDemo
	When he logins on the portal
		| user          | password     |
		| standard_user | secret_sauce |
	Then he should see the products

Scenario: Login with incorrect password
	Given Juan is on SauceDemo
	When he logins on the portal
		| user          | password     |
		| standard_user | bad_password |
	Then he should see a message that "Epic sadface: Username and password do not match any user in this service"

Scenario Outline: Failure logins
	Given Juan is on SauceDemo
	When he logins on the portal
		| user   | password   |
		| <user> | <password> |
	Then he should see a message that
		| message   |
		| <message> |

	Examples:
		| user            | password     | message                                                                   |
		| standard_user   | bad_password | Epic sadface: Username and password do not match any user in this service |
		| locked_out_user | secret_sauce | Epic sadface: Sorry, this user has been locked out.                       |