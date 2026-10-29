<div align="center">

#  Windows Programming Course
### Chapter 2: C# Fundamentals — Complete Exercise Solutions

[![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Status](https://img.shields.io/badge/Exercises-29%2F29%20Completed-success?style=for-the-badge)]()

<p align="center">
  A comprehensive collection of <b>29 standalone C# console applications</b> covering core language syntax, object-oriented fundamentals, control structures, algorithmic loops, arrays, and string manipulation.
</p>

[Explore Exercises](#-exercise-directory-129) • [Getting Started](#-getting-started) • [How to Run](#-how-to-run-the-exercises) • [Author](#-author)

</div>

---

##  Table of Contents
- [ About The Repository](#-about-the-repository)
- [ Core Concepts Covered](#-core-concepts-covered)
- [ Exercise Directory (1–29)](#-exercise-directory-129)
  - [Part 1: Syntax, Data Types & Operators](#part-1-syntax-data-types--operators)
  - [Part 2: Control Flow & Conditional Statements](#part-2-control-flow--conditional-statements)
  - [Part 3: Loops, Patterns & Mathematical Methods](#part-3-loops-patterns--mathematical-methods)
  - [Part 4: Arrays & Data Collections](#part-4-arrays--data-collections)
  - [Part 5: String Manipulation & Formatting](#part-5-string-manipulation--formatting)
- [ Prerequisites](#-prerequisites)
- [Getting Started](#-getting-started)
- [How to Run the Exercises](#️-how-to-run-the-exercises)
- [Author](#-author)

---

##  About The Repository

This repository serves as the official coursework submission for **Chapter 2 (C# Fundamentals)** of the **Windows Programming** course. Every exercise from the lecture slides has been implemented, tested, and organized into its own individual `.cs` source file (`Exercise1.cs` through `Exercise29.cs`) for straightforward code review and grading.

---

##  Core Concepts Covered

* **Program Structure & OOP Basics:** Namespaces, classes, objects, member variables, methods, and entry points (`Main`).
* **Type System & Memory:** Value types vs. reference types, implicit/explicit casting, `Convert` methods, and identifier rules.
* **Operators & Expressions:** Arithmetic operations, operator precedence, and associativity.
* **Decision Making:** Conditional branching (`if-else`), `switch-case` blocks, and resolving the dangling-else problem.
* **Iteration & Loops:** `for`, `while`, `do-while`, and `foreach` loops, nested loop matrices, and infinite loop debugging.
* **Modular Programming:** Static methods, parameter passing, and mathematical digit extraction without string helpers.
* **Arrays:** Single-dimensional array traversal, sorting, frequency counting, and min/max algorithms.
* **Strings:** Character indexing, `Split()`, `Substring()`, `Replace()`, `Trim()`, word counting, title-casing, and palindrome verification.

---

##  Exercise Directory (1–29)

### Part 1: Syntax, Data Types & Operators
| File | Exercise | Slide | Problem Description |
| :--- | :--- | :---: | :--- |
|  `Exercise1.cs` | **Exercise 1** | 22 | Identify valid and invalid C# variable identifiers (`Class`, `_2pac`, `2pac`, `new`, etc.) |
|  `Exercise2.cs` | **Exercise 2** | 23 | Declare appropriate data types and attributes for a marketing company's employee record |
|  `Exercise3.cs` | **Exercise 3** | 34–35 | Evaluate integer/float division, modulus, operator precedence, and OOP `Addition` class |

### Part 2: Control Flow & Conditional Statements
| File | Exercise | Slide | Problem Description |
| :--- | :--- | :---: | :--- |
|  `Exercise4.cs` | **Exercise 4** | 40 | Convert a numeric score into a letter grade (`A`, `B`, `C`, `D`, `F`) |
|  `Exercise5.cs` | **Exercise 5** | 41 | Convert an input digit (`0–9`) into its English word equivalent using `switch` |
| 📄 `Exercise6.cs` | **Exercise 6** | 42 | Trace and fix the **Dangling Else** problem using explicit block scoping |

### Part 3: Loops, Patterns & Mathematical Methods
| File | Exercise | Slide | Problem Description |
| :--- | :--- | :---: | :--- |
| 📄 `Exercise7.cs` | **Exercise 7** | 46 | Calculate the sum of numbers from `x` to `y` and print a right-aligned star triangle |
| 📄 `Exercise8.cs` | **Exercise 8** | 47 | Calculate the sum of integers from `1` to `10` and print a left-aligned star triangle |
| 📄 `Exercise9.cs` | **Exercise 9** | 48 | Analyze unexecuted/infinite "bad loops" and demonstrate corrected loop conditions |
| 📄 `Exercise10.cs` | **Exercise 10** | 49 | Identify and fix the `while (start != num)` infinite loop bug for odd inputs |
| 📄 `Exercise11.cs` | **Exercise 11** | 50 | Generate a triangular multiplication table (`i * 1` up to `i * i`) for `N` lines |
| 📄 `Exercise12.cs` | **Exercise 12** | 51 | Read positive integer `N (N < 20)` and output a shifted `N x N` number matrix |
| 📄 `Exercise13.cs` | **Exercise 13** | 52 | `DivisibleBy2Or3(a, b)` — return product if both are divisible by 2 or 3, otherwise sum |
| 📄 `Exercise14.cs` | **Exercise 14** | 53 | `IfYearIsLeap(year)` — determine whether a given year is a leap year |
| 📄 `Exercise15.cs` | **Exercise 15** | 54 | `ReturnEvenNumbers()` — return a space-separated string of even numbers `(0 < n < 100)` |
| 📄 `Exercise16.cs` | **Exercise 16** | 55 | `IfNumberContains3(n)` — check if an integer contains digit `3` without type conversion |
| 📄 `Exercise17.cs` | **Exercise 17** | 56 | `DigitsSum(n)` — compute the sum of all digits in a non-negative integer |
| 📄 `Exercise18.cs` | **Exercise 18** | 57 | Extract and display the first and last digit of any positive integer |
| 📄 `Exercise19.cs` | **Exercise 19** | 58 | `NumberOfEvenDigits(n)` — count even digits mathematically using modulo/division |
| 📄 `Exercise20.cs` | **Exercise 20** | 59 | Calculate the product of all digits of an input number |

### Part 4: Arrays & Data Collections
| File | Exercise | Slide | Problem Description |
| :--- | :--- | :---: | :--- |
| 📄 `Exercise21.cs` | **Exercise 21** | 73 | `IfSortedAscending(arr)` — check if a 3-element integer array is sorted in ascending order |
| 📄 `Exercise22.cs` | **Exercise 22** | 74 | Count and display the occurrence frequency of each element in an array |
| 📄 `Exercise23.cs` | **Exercise 23** | 75 | Find the maximum and minimum values stored in an integer array |
| 📄 `Exercise24.cs` | **Exercise 24** | 76 | Count the total number of even and odd integers in an array |
| 📄 `Exercise25.cs` | **Exercise 25** | 77 | `secondLargestElement(arr)` — find the second largest integer in an array |

### Part 5: String Manipulation & Formatting
| File | Exercise | Slide | Problem Description |
| :--- | :--- | :---: | :--- |
| 📄 `Exercise26.cs` | **Exercise 26** | 90 | Count total words in a string by checking spaces, tabs (`\t`), and newlines (`\n`) |
| 📄 `Exercise27.cs` | **Exercise 27** | 91 | Print individual characters of an input string in reverse order |
| 📄 `Exercise28.cs` | **Exercise 28** | 92 | Capitalize the first letter of every word in an arbitrary user string |
| 📄 `Exercise29.cs` | **Exercise 29** | 93 | Check whether a word or phrase (e.g., `"madam"`, `"nurses run"`) is a palindrome |

---

## 🛠️ Prerequisites

To compile and run these programs locally, ensure you have one of the following installed:
* **[Microsoft Visual Studio 2022+](https://visualstudio.microsoft.com/)** (with the *.NET Desktop Development* workload)
* **[.NET SDK (6.0 / 8.0 / 10.0+)](https://dotnet.microsoft.com/download)**

---

## 🚀 Getting Started

Clone this repository to your local machine using Git:

```bash
git clone https://github.com/yishakarsenal-rgb/window-programming-course.git
cd window-programming-course
```

---

## ▶️ How to Run the Exercises

Because each `.cs` file is written as a complete, self-contained program with its own `static void Main(string[] args)` method, you can run them using any of the methods below:

### Option 1: Using Visual Studio
1. Open **Visual Studio** and create or open a **C# Console App** project.
2. Copy the contents of any exercise file (e.g., `Exercise15.cs`) into `Program.cs` (or include the specific `.cs` file in your project one at a time).
3. Press **`Ctrl + F5`** (*Start Without Debugging*) to compile and run.

### Option 2: Using .NET 10+ Single-File Execution (CLI)
If you have the modern .NET CLI installed, you can run any individual `.cs` file directly from the terminal:
```bash
dotnet run Exercise1.cs
```

### Option 3: Using the C# Compiler (`csc`) in Developer Command Prompt
Open the **Developer Command Prompt for Visual Studio**, navigate to the repository folder, and compile any file directly:
```bash
csc Exercise1.cs
./Exercise1.exe
```

---

## 👤 Author

**Yishak Mekuannent**
* **GitHub:** [@yishakarsenal-rgb](https://github.com/yishakarsenal-rgb)
* **Course:** Windows Programming (Chapter 2 — C# Fundamentals)

---

<div align="center">
  <i>If you found this repository helpful or well-organized, feel free to give it a ⭐!</i>
</div>