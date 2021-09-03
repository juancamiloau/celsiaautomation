Feature: Login
	Este es el login para la aplicación de SauceDemo


Scenario: Login exitoso
	Given Juan esta en el inicio de sesión
	When él se loguea
	Then él debería de ver la página de productos

Scenario: Login fallido por credenciales
	Given Juan esta en el inicio de sesión
	When él se loguea con credenciales incorrectas
	Then él debería de ver el siguiente mensaje Epic sadface: Username and password do not match any user in this service