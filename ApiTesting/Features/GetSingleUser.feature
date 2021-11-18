Feature: GetSingleUser
	Endpoint for get users of an organization


Scenario: Get single user success
	Given that Juan connect to https://reqres.in/
	When he gets the user 1
	Then he should see the response is 200
	And he should see that data is correct
	| email                  | first_name | last_name |
	| george.bluth@reqres.in | George     | Bluth     | 