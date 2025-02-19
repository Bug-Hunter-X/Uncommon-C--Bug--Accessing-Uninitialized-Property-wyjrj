# Uninitialized Property Access in C#

This repository demonstrates a common yet subtle error in C#: accessing a property before it has been assigned a value.  This can lead to unpredictable results, especially in multi-threaded environments or when dealing with complex object initialization.

## The Problem
The `bug.cs` file shows a class with a property that is accessed within a method before it is explicitly initialized.  This can result in the property holding its default value (0 for integers, null for references), leading to unexpected behavior.

## The Solution
The `bugSolution.cs` file illustrates how to solve this. Initialization is done in the constructor, ensuring that the property always has a defined value before it's accessed.

## How to Run
1. Clone the repository
2. Open `bug.cs` and `bugSolution.cs` in your preferred C# IDE
3. Run the code to see the difference in behavior.