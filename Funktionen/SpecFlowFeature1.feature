Feature: Taschenrechner trigonometrische Funktionen
	Als Kunde möchte ich einen Taschenrechner haben, welcher die trigonimischen Funktionen berechnen kann, damit die Berechnungen korrekt sind.


Scenario: Sinus
	Given The customer clicks on <sinus>
	When the customer enter the number 3.14159
	Then the result should be 0

	Scenario: Cosinus
	Given the first number is <PI>
	When the customer enter the number 3.14159
	Then the result should be -1

	Scenario: Tangens
	Given the first number is <PI>
	When the customer enter the number 3.14159
	Then the result should be 0