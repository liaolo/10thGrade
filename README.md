# 10thGrade
[![Ask DeepWiki](https://devin.ai/assets/askdeepwiki.png)](https://deepwiki.com/liaolo/9thGrade.git)

This repository contains a collection of C# programming exercises and assignments, likely from a 9th-grade computer science curriculum. The project is a .NET console application demonstrating fundamental programming concepts through various practical problems.

## Project Structure & Concepts

The repository is organized into several C# files, each focusing on a specific programming concept.

### Array Manipulation

A significant portion of the repository is dedicated to array-based problems, showcasing a wide range of use cases.

*   **`ArraysPractice.cs`**: Covers fundamental array operations such as calculating averages, finding the distance of elements from the average, and reversing array contents.
*   **`ArraysPractice2.cs`**: Implements array rotation/shifting and simulates a simple board game mechanic where a player's position is updated based on a dice roll and values in an array.
*   **`ArraysPractice3.cs`**: Demonstrates the use of "counter arrays" to solve problems like tallying votes in an election, counting the frequency of dice rolls, and tracking color draws in a game. It also includes exercises on managing parallel arrays (e.g., student grades).
*   **`ArraysPractice4.cs`**: Contains more advanced analysis problems, such as tracking medication consumption by age group and identifying which items were not used at all.

### String Practice

**`StringPractice.cs`** contains a variety of functions for string manipulation, including:
*   Searching for characters and substrings.
*   Comparing string length and content.
*   Reversing a string.
*   Converting character case.
*   Lexicographical comparison.
*   Finding the longest common prefix between two strings.
*   Counting "peaks" in an integer array (where an element is greater than its neighbors).

### Nested Loops

**`NesttedLoops.cs`** focuses on exercises solved using nested loops. Key examples include:
*   Printing various geometric patterns with characters (e.g., triangles, rectangles).
*   Processing data in batches, such as calculating average grades for multiple students.
*   Finding the longest series of inputs from a user.
*   A function to check for prime numbers.

### Cryptography

**`Caesar.cs`** provides a basic implementation of two ciphers:
*   **Caesar Cipher**: Functions to encrypt and decrypt text by shifting characters by a given key.
*   **Transposition Cipher**: A simple cipher that encrypts a string by swapping adjacent characters.

### Object-Oriented Programming

The project includes an introduction to object-oriented concepts with a few custom classes.

*   **`CssGrades.cs`**: A class designed to model a student's computer science grades. It encapsulates different grade components (test scores, project scores) and provides methods to calculate the final grade for 3 or 5-unit tracks.
*   **`MusicTimeCac.cs`**: A class to represent an artist's music collection. It stores song names and durations, and includes methods to calculate the total listening time and find the longest song.
*   **`ClassPractice.cs`**: A utility class with `UnitTests` methods to demonstrate the functionality of the `CssGrades` and `MusicTimeCac` classes.

## Getting Started

### Prerequisites
*   [.NET SDK](https://dotnet.microsoft.com/download)

### How to Run

1.  Clone the repository to your local machine:
    ```sh
    git clone https://github.com/liaolo/9thgrade.git
    cd 9thgrade
    ```

2.  Open the `Program.cs` file. Inside the `Main` method, you will find several commented-out lines that call the `UnitTest()` method from different classes.

3.  Uncomment the line corresponding to the set of exercises you wish to run. For example, to run the string manipulation exercises:
    ```csharp
    static void Main(string[] args)
    {
        //NesttedLoops.UnitTest();
        StringPractice.UnitTest(); // Uncomment this line
        //Caesar.UnitTest();
        //ArraysPractice.UnitTest();
        //ArraysPractice2.UnitTest();
        //ClassPractice.UnitTests();
    }
    ```

4.  Run the application from your terminal:
    ```sh
    dotnet run
