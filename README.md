# Bank Statement Analyzer

A C# console application that reads a bank statement CSV file and summarizes spending by category.

## Features

- Imports transactions from a CSV file
- Automatically categorizes purchases
- Calculates total spending by category
- Displays a spending summary

## Technologies

- C#
- .NET
- Object-Oriented Programming
- File I/O
- Dictionaries

## Project Structure

Models  
Transaction.cs – represents a bank transaction

Services  
CsvImporter.cs – reads the CSV file  
Categorizer.cs – assigns categories to transactions  
Analyzer.cs – calculates totals

Program.cs – application entry point

## Example Output
Spending Summary

Other: $1157.90
Shopping: $80.22
Entertainment: $28.98
Transportation: $18.50
Coffee: $6.75


## Sample CSV Format
Date,Description,Amount
2025-03-01,Starbucks,-6.75
2025-03-02,Amazon,-80.22
2025-03-03,Uber,-18.50


## Run the Application
dotnet run