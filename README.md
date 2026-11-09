# 💻 Windows Programming Course — C# Fundamentals & OOP

[![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/.NET-Console_App-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![IDE](https://img.shields.io/badge/IDE-Visual_Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Author](https://img.shields.io/badge/Author-Yishak_Mekuannent-0A66C2?style=for-the-badge&logo=github&logoColor=white)](https://github.com/yishakarsenal-rgb)

> **Course:** Windows Programming (COSC-4021)  
> **Author:** Yishak Mekuannent ([@yishakarsenal-rgb](https://github.com/yishakarsenal-rgb))  
> **Repository:** [window-programming-course](https://github.com/yishakarsenal-rgb/window-programming-course)

---

## 📑 Table of Contents

- [📖 Overview](#-overview)
- [📘 Chapter 2: C# Fundamentals (Exercises 1–29)](#-chapter-2-c-fundamentals-exercises-129)
  - [1. Syntax, Variables & Operators](#1-syntax-variables--operators)
  - [2. Control Flow & Loops](#2-control-flow--loops)
  - [3. Methods & Number Manipulation](#3-methods--number-manipulation)
  - [4. Arrays](#4-arrays)
  - [5. Strings](#5-strings)
- [📙 Chapter 3: Object-Oriented Programming (Exercises 1–16)](#-chapter-3-object-oriented-programming-exercises-116)
  - [1. Classes, Objects & Constructors](#1-classes-objects--constructors)
  - [2. Encapsulation, Properties & Static Members](#2-encapsulation-properties--static-members)
  - [3. Inheritance & Constructor Chaining](#3-inheritance--constructor-chaining)
  - [4. Polymorphism & Abstract Classes](#4-polymorphism--abstract-classes)
- [🚀 Getting Started & How to Run](#-getting-started--how-to-run)
- [🛠️ Tech Stack & Tools](#️-tech-stack--tools)

---

## 📖 Overview

This repository contains **45 standalone C# exercises** covering the core curriculum of **Windows Programming**:
* **Chapter 2: C# Fundamentals** — **29 exercises** covering variables, data types, operators, conditional statements, loops, methods, arrays, and string processing[cite: 1].
* **Chapter 3: Object-Oriented Programming (OOP)** — **16 exercises** covering classes, objects, constructors, destructors, C# properties, indexers, static members, inheritance, polymorphism, and abstract classes[cite: 7].

---

## 📘 Chapter 2: C# Fundamentals (Exercises 1–29)

### 1. Syntax, Variables & Operators

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Exercise1.cs` | Exercise 1 | Slide 22 | Identify valid and invalid C# variable identifiers (`Class`, `_2pac`, `greeting`, `numberOfClients` vs. `2pac`, `new`)[cite: 1]. |
| `Exercise2.cs` | Exercise 2 | Slide 23 | Declare appropriate variables and data types for a marketing company's employee record[cite: 1]. |
| `Exercise3.cs` | Exercise 3 | Slide 34–35 | Evaluate arithmetic expressions (`10/3`, `5.2/2.0`, `9%3`), operator precedence, and a two-number addition class[cite: 1]. |

### 2. Control Flow & Loops

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Exercise4.cs` | Exercise 4 | Slide 40 | Convert a numeric grade into a letter grade (`A`, `B`, `C`, `D`, `F`) using `if-else` ranges[cite: 1]. |
| `Exercise5.cs` | Exercise 5 | Slide 41 | Convert a single digit (`0–9`) into its English word using a `switch` statement[cite: 1]. |
| `Exercise6.cs` | Exercise 6 | Slide 42 | Demonstrate and fix the **Dangling Else** problem using explicit block scoping `{}`[cite: 1]. |
| `Exercise7.cs` | Exercise 7 | Slide 46 | Calculate the sum of numbers from `x` to `y` and print a right-aligned star triangle[cite: 1]. |
| `Exercise8.cs` | Exercise 8 | Slide 47 | Calculate the sum of integers from `1` to `10` and print a left-aligned star triangle[cite: 1]. |
| `Exercise9.cs` | Exercise 9 | Slide 48 | Analyze faulty/infinite loop conditions and demonstrate corrected loop structures[cite: 1]. |
| `Exercise10.cs` | Exercise 10 | Slide 49 | Fix the `while (start != num)` infinite loop bug when odd numbers are entered[cite: 1]. |
| `Exercise11.cs` | Exercise 11 | Slide 50 | Generate a triangular multiplication table (`i * 1` through `i * i`) for `N` lines[cite: 1]. |
| `Exercise12.cs` | Exercise 12 | Slide 51 | Read a positive integer `N (N < 20)` and print a shifted `N x N` number matrix[cite: 1]. |

### 3. Methods & Number Manipulation

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Exercise13.cs` | Exercise 13 | Slide 52 | `DivisibleBy2Or3(a, b)` — Return `a * b` if both are divisible by 2 or 3; otherwise return `a + b`[cite: 1]. |
| `Exercise14.cs` | Exercise 14 | Slide 53 | `IfYearIsLeap(year)` — Check whether a given year is a leap year[cite: 1]. |
| `Exercise15.cs` | Exercise 15 | Slide 54 | `ReturnEvenNumbers()` — Return a formatted string of all even numbers greater than 0 and less than 100[cite: 1]. |
| `Exercise16.cs` | Exercise 16 | Slide 55 | `IfNumberContains3(n)` — Check if a positive integer contains the digit `3` without string conversion[cite: 1]. |
| `Exercise17.cs` | Exercise 17 | Slide 56 | `DigitsSum(n)` — Compute and return the sum of digits of a non-negative integer[cite: 1]. |
| `Exercise18.cs` | Exercise 18 | Slide 57 | Extract and display the first and last digit of an input number[cite: 1]. |
| `Exercise19.cs` | Exercise 19 | Slide 58 | `NumberOfEvenDigits(n)` — Count the number of even digits in a positive integer mathematically[cite: 1]. |
| `Exercise20.cs` | Exercise 20 | Slide 59 | Calculate the product of all digits of any input number[cite: 1]. |

### 4. Arrays

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Exercise21.cs` | Exercise 21 | Slide 73 | `IfSortedAscending(arr)` — Check if a 3-element integer array is sorted in ascending order[cite: 1]. |
| `Exercise22.cs` | Exercise 22 | Slide 74 | Count and display the frequency of each unique element in an array[cite: 1]. |
| `Exercise23.cs` | Exercise 23 | Slide 75 | Find the maximum and minimum elements in an integer array[cite: 1]. |
| `Exercise24.cs` | Exercise 24 | Slide 76 | Count the total number of even and odd integers in an array using `foreach`[cite: 1]. |
| `Exercise25.cs` | Exercise 25 | Slide 77 | `secondLargestElement(arr)` — Find and return the second largest element in an integer array[cite: 1]. |

### 5. Strings

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Exercise26.cs` | Exercise 26 | Slide 90 | Count the total number of words in a string (checking spaces, newlines `\n`, and tabs `\t`)[cite: 1]. |
| `Exercise27.cs` | Exercise 27 | Slide 91 | Print the individual characters of a string in reverse order[cite: 1]. |
| `Exercise28.cs` | Exercise 28 | Slide 92 | Capitalize the first letter of every word in an arbitrary user string[cite: 1]. |
| `Exercise29.cs` | Exercise 29 | Slide 93 | Check whether an input word or phrase is a palindrome (e.g., `madam`, `nurses run`)[cite: 1]. |

---

## 📙 Chapter 3: Object-Oriented Programming (Exercises 1–16)

### 1. Classes, Objects & Constructors

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Ch3_Exercise1.cs` | Exercise 1 | Slide 43 | Create a `House` class (`length`, `width`, `area`, constructor, `ShowData()`) and test it in `TestClass`[cite: 7]. |
| `Ch3_Exercise2.cs` | Exercise 2 | Slide 44 | Create a `Person` class (`name`, `age`, constructor, `PrintData()`) and instantiate two objects in `TestClass`[cite: 7]. |
| `Ch3_Exercise3.cs` | Exercise 3 | Slide 45 | `Program3` & `TestProgram3` — `checkIf5()` returns `true` if either integer is 5, or their sum/difference is 5[cite: 7]. |
| `Ch3_Exercise4.cs` | Exercise 4 | Slide 46 | `Circle` & `TestCircle` — Overloaded constructors, private fields (`radius`, `color`), `getPerimeter()`, and `getArea()`[cite: 7]. |
| `Ch3_Exercise5.cs` | Exercise 5 | Slide 47 | `Program5` & `TestProgram5` — `checkIfPossible()` checks if two integers can be added to get the third integer[cite: 7]. |
| `Ch3_Exercise6.cs` | Exercise 6 | Slide 48 | `Program6` & `TestProgram6` — `checkRigtmostDigit()` checks if two or more non-negative integers share the same rightmost digit. |
| `Ch3_Exercise7.cs` | Exercise 7 | Slide 49 | `Program7` & `TestProgram7` — Rectangle class using `getLength`, `setLength`, `getWidth`, `setWidth`, and `caculateArea`. |
| `Ch3_Exercise8.cs` | Exercise 8 | Slide 50 | `Program8` & `TestProgram8` — `checkNearest()` finds which of two integers is nearest to `100` (returns `0` if equal). |

### 2. Encapsulation, Properties & Static Members

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Ch3_Exercise9.cs` | Exercise 9 | Slide 62 | `Month` & `TestMonth` — Private month number encapsulated with C# property, returning month name and days (`DisplayDetail()`). |
| `Ch3_Exercise10.cs` | Exercise 10 | Slide 63–64 | `Student` & `StudentTest` — Overloaded constructors, C# properties, `static` object counter, and student info display. |

### 3. Inheritance & Constructor Chaining

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Ch3_Exercise11.cs` | Exercise 11 | Slide 86–87 | `Human` base class inherited by `Student` (`Mark`) and `Worker` (`Wage`, `Hours`, hourly wage calculation). |
| `Ch3_Exercise12.cs` | Exercise 12 | Slide 88 | `Member` base class (`PrintSalary()`) inherited by `Employee` (`specialization`) and `Manager` (`department`). |

### 4. Polymorphism & Abstract Classes

| File | Exercise | Slide | Description |
| :--- | :--- | :--- | :--- |
| `Ch3_Exercise13.cs` | Exercise 13 | Slide 110 | Abstract class `Shape` (`CalculateSurface()`) implemented by `Rectangle`, `Triangle`, and `Circle`. |
| `Ch3_Exercise14.cs` | Exercise 14 | Slide 111 | Abstract class `BankAccount` (`deposit()`, `withdraw()`) inherited and implemented by `SavingsAccount`. |
| `Ch3_Exercise15.cs` | Exercise 15 | Slide 112 | Abstract class `Employee` (`calculateSalary()`, `displayInfo()`) extended by `Manager` (bonus) and `Programmer` (overtime). |
| `Ch3_Exercise16.cs` | Exercise 16 | Slide 113 | Abstract class `Marks` (`getPercentage()`) inherited by class `A` (3 subjects) and class `B` (4 subjects). |

---

## 🚀 Getting Started & How to Run

### Prerequisites
* [.NET SDK](https://dotnet.microsoft.com/download) (.NET 6.0 / 8.0 / 10.0)
* [Microsoft Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### 1. Clone the Repository
```bash
git clone [https://github.com/yishakarsenal-rgb/window-programming-course.git](https://github.com/yishakarsenal-rgb/window-programming-course.git)
cd window-programming-course