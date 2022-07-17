# BakeryBot

#### About

Point of Sale App: receives orders, applies discounts unique to each product, confirms total cost.

#### By Kyle Chinick

## Technologies Used

- _C#_
- _MS Test_
- _.Net 5.0_

## Description

The BakeryBot app is a C# console app that demos a terminal-based Point of Sale 'robot'.

Upon launching the app the BakeryBot will write a welcome message and menu to the terminal. The menu for the imaginary bakery, Pierre's Bakery, lists each bakery product, their standard costs and their unique product-based discounts.

The user is then asked how many of each product they would like to order and, upon submitting the final order quantity the BakeryBot will:

- Save each product and product-quantity.
- Run each set of product/quantity data through their respective product class methods.
- Confirm product costs with discounts applied.
- Confirm the grand total of the entire order.

## Setup/Installation Requirements

1. Clone this repository to your desktop by executing `git clone https://github.com/kylechinick/BakeryBot.git` in your preferred terminal application.
2. In the terminal, cd into the BakeryBot directory then execute `dotnet restore` in the terminal to auto-populate the directory with an `obj` directory and its required contents.
3. To start and run the app execute `dotnet run` or, optionally, `dotnet watch run` to start the app and cause it to rebuild and run after each change to the codebase.
4. Optional: in order to test the application's class methods cd into the BakeryBot.Tests folder and execute `dotnet test` in the terminal.

## Known Bugs

- N/A
