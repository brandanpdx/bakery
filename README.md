# _Epicodus Independent Project - February 28, 2020_

#### By _**Brandan Sayarath**_

## Description

This is the Epicodus independent end-of-week assignment for Friday, February 28, 2020.  The purpose of this assignment is to create a console application for a bakery.  

## Behavior Driven Development Specifications

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
| Program prompts welcome message, displays current prices, and the curent special | User starts program | "Welcome to Pierre's Bakery.  Bread is $5.00 per loaf.  Pastries are $2 each." TODAY'S SPECIALS: Buy 2 loaves of bread, get 1 free!  Buy 3 pastries for $5!|
| Program will ask how many loaves of bread the user wants to purchase| 2 | "2 loaves of bread added to cart!" |
|Program will ask how many pastries the user wants to purchase | 2 | "2 pastries added to cart!" | 
|Program will ask if user is done shopping| Y | Program displays confirmation of order |
| Program will ask if user is done shopping | N | Program prompts user if they want to change their order |
| If user enters "N" when the program asks if they're done with the order, the program will restart | N| "Welcome to Pierre's Bakery.  Bread is $5.00 per loaf.  Pastries are $2 each." TODAY'S SPECIALS: Buy 2 loaves of bread, get 1 free!  Buy 3 pastries for $5! |
| If user enters "Y" when the program asks if they're done with the order, the program will add the subtotal of their bread order, and subtotal of their pastry order and display the grand total of both | Y | Bread Total: $15 <br> Pastry Total: $5 <br> Grand Total: $20 | 





## Setup/Installation Requirements

#### Install this application

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/brandanpdx/bakery```
* ```$ cd bakery```

Then, confirm that you have navigated to the bakery project directory by entering ```pwd``` in Terminal.

To run the program, type the following into the terminal: 

* ```$ dotnet run```


## Support and Contact

Please email Brandan Sayarath: brandan@brandan.tech for any questions.

## Technologies Used

This program was created with:

* C#
* .NET Core
* Git

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 **_Brandan Sayarath_**

