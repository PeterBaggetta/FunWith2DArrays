# FunWith2DArrays

A simple, interactive C# console program that explores **2D arrays** in a fun way — by generating colorful grids filled with symbols, coordinates, or number sequences.  

---

## Features

- **Customizable Grid Size**  
  Choose any number of rows and columns.

- **Three Fill Modes**  
  1. **Colourful Symbols** – Random symbols in random colors  
  2. **Coordinates** – `(row, column)` for each cell  
  3. **Number Sequence** – Counting numbers that fill the grid in order  

- **Aligned and Clean Grid**  
  Automatically calculates cell width so columns and separators always line up, even for large grids.

- **Random Colors**  
  Uses [Colorful.Console](https://github.com/tomakita/Colorful.Console) to display bright, visually distinct grids.

---

## How It Works

1. **Input Stage**  
   - Prompts the user for number of rows and columns  
   - Validates that both are greater than zero  

2. **Mode Selection**  
   - Lets the user pick one of three fill modes  

3. **Grid Generation**  
   - Dynamically calculates cell width  
   - Fills each cell based on the chosen mode  
   - Randomizes colors when using colorful symbols  
   - Prints column separators (`|`) and row separators (`---+---+`) so everything stays visually aligned  

---

## Purpose

This project is designed to:
- Practice **multidimensional arrays** in C#
- Learn about **2D array-like thinking** (row/column traversal)
- Experiment with **dynamic console output** and **colored text**
- Show how simple logic can produce engaging console visuals

---

## Installation of Dependencies

- **Install Colorful.Console**  
   Using .NET CLI:
   ```bash
   dotnet add package Colorful.Console
