# Command-Based Calculator Application

This repository contains a **Command-Based Calculator Application** developed in **C#**. The application accepts an initial value and processes a series of commands to manipulate the value. It supports operations like increment, decrement, double, random addition, and undo. The application follows the **Command Design Pattern** for modularity and extensibility.

---

## Table of Contents
- [Introduction](#introduction)
- [Key Features](#key-features)
- [Technical Details](#technical-details)
- [Code Structure](#code-structure)
- [How It Works](#how-it-works)
- [Example Usage](#example-usage)
- [Assumptions](#assumptions)
- [Future Enhancements](#future-enhancements)
- [Conclusion](#conclusion)

---

## Introduction
This application was developed as part of a task assigned during a job interview process. It demonstrates:
- **Clean Code Practices**: Modular, readable, and maintainable code.
- **Design Patterns**: Effective use of the **Command Design Pattern**.
- **Error Handling**: Robust handling of invalid inputs and edge cases.
- **Extensibility**: Easy addition of new commands without modifying existing code.

---

## Key Features
- **Command-Line Interface**:
  - Accepts an initial value as input.
  - Supports the following commands:
    - `increment`: Increases the result by 1.
    - `decrement`: Decreases the result by 1.
    - `double`: Multiplies the result by 2.
    - `randadd`: Adds a random number between 1 and 100 to the result.
    - `undo`: Reverts the most recent non-undo command.
- **Undo Functionality**:
  - Maintains a history of results using a stack.
  - Allows reverting to the previous state using the `undo` command.
- **Error Handling**:
  - Validates user input for the initial value.
  - Handles invalid commands gracefully.
- **Extensibility**:
  - New commands can be added by implementing the `ICommand` interface.

---

## Technical Details

### Architecture
The application is built using the **Command Design Pattern**, which encapsulates each operation as a separate command object. This design ensures:
- **Separation of Concerns**: Each command is responsible for its own logic.
- **Modularity**: Commands can be added or modified without affecting other parts of the code.
- **Reusability**: Command objects can be reused in other applications.

### Components
- **`ICommand` Interface**:
  - Defines the contract for all commands.
  - Includes two methods:
    - `Execute(int currentResult)`: Executes the command and returns the new result.
    - `Undo(int currentResult)`: Reverts the command and returns the previous result.
- **Command Classes**:
  - `IncrementCommand`: Increments the result by 1.
  - `DecrementCommand`: Decrements the result by 1.
  - `DoubleCommand`: Doubles the result.
  - `RandAddCommand`: Adds a random number to the result.
  - `UndoCommand`: Reverts the most recent non-undo command.
- **Main Program**:
  - Initializes the result and command history.
  - Prompts the user for commands in an infinite loop.
  - Executes commands and updates the result.
- **History Management**:
  - Uses a `Stack<int>` to track previous results.
  - Enables undo functionality by reverting to the previous state.

---

## Code Structure
The project consists of the following files:
- `ICommand.cs`: Defines the `ICommand` interface.
- `IncrementCommand.cs`: Implements the `IncrementCommand` class.
- `DecrementCommand.cs`: Implements the `DecrementCommand` class.
- `DoubleCommand.cs`: Implements the `DoubleCommand` class.
- `RandAddCommand.cs`: Implements the `RandAddCommand` class.
- `UndoCommand.cs`: Implements the `UndoCommand` class.
- `Program.cs`: Contains the `Main` method and program logic.

---

## How It Works

### Initialization
- The program starts by prompting the user for an initial value.
- The value is validated to ensure it is a valid integer.

### Command Execution
- The user enters commands one by one.
- Each command is executed, and the result is updated.
- The result is displayed after each command.

### Undo Operation
- The `undo` command reverts to the most recent non-undo command.
- The history stack is used to track and restore previous results.

### Exit
- The program runs in an infinite loop until manually terminated.

---

## Example Usage

### Input
```plaintext
Enter the initial value: 1
Enter command (increment, decrement, double, randadd, undo): increment
Enter command (increment, decrement, double, randadd, undo): increment
Enter command (increment, decrement, double, randadd, undo): increment
Enter command (increment, decrement, double, randadd, undo): double
Enter command (increment, decrement, double, randadd, undo): undo
Enter command (increment, decrement, double, randadd, undo): undo
```

### Output
```plaintext
Current result: 2
Current result: 3
Current result: 4
Current result: 8
Current result: 4
Current result: 3
```

---

## Assumptions
- **Input Validation**:
  - The initial value must be a valid integer.
  - Commands are case-insensitive and must match one of the supported commands.
- **Undo Limitations**:
  - The `undo` command cannot be undone.
  - If there is no history to undo, the program notifies the user.
- **Random Addition**:
  - The random number added by `randadd` is between 1 and 100.

---

## Future Enhancements
- **Additional Commands**:
  - Add commands like `divide`, `square`, or `reset`.
- **GUI**:
  - Develop a graphical user interface for better user interaction.
- **Command History**:
  - Display a list of all executed commands.

---

## Conclusion
This application demonstrates a clean, modular, and extensible implementation of a command-based calculator. It uses best practices in software design, including design patterns, error handling, and separation of concerns. The code is well-documented and easy to maintain, showcasing my programming skills and attention to detail.

---

**Developer Name**: Muhammad Zubair  
