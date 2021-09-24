Feature: ShoppingCart
	Add or remove items that you want to buy

Scenario: Add one item
	Given Juan is on SauceDemo
	And he logins on the portal
		| user          | password     |
		| standard_user | secret_sauce |
	When he adds items to cart
	Then he should see the count of items in the car