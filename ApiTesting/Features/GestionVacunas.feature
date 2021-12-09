Feature: GestionVacunas
Endpoint for count vacinne on Valle del Cauca


Scenario: Get all city vaccine counts
	Given that Juan connect to http://83.136.219.13/~felix/code/public/index.php/
	When he gets of vaccines for city
	Then he should see the schema is correct
