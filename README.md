# Custom Linked List 

## Overview
This project is a basic implementation of a singly linked list in C#. It’s designed to help you understand how linked lists work and to practice fundamental operations like adding, removing, and searching for nodes. The code is split into separate files for clarity, making it easy to see how each piece fits together.

## Purpose
The goal here is to:
- **Learn Linked Lists:** Get hands-on with a simple data structure where each element (node) points to the next one.
- **Teach Implementation:** Demonstrate how to write basic methods to manage a linked list, step-by-step.
- **Explore C# Basics:** Practice object-oriented programming and class interactions in C#.

This project is perfect if you’re new to data structures or want a refresher on how linked lists operate under the hood.

## Project Structure
- **Node.cs:** Defines the Node class, which holds a value (`Data`) and a reference to the next node (`Next`).
- **CustomLinkedList.cs:** Contains the `CustomLinkedList` class with methods to manipulate the list (e.g., append, prepend, remove).
- **Program.cs:** The entry point where we test the linked list with several examples to see it in action.

All files share the `LinkedListDemo` namespace to keep them connected.

## What’s Inside
The `CustomLinkedList` class includes these core operations:
- **Append:** Add a node to the end of the list.
- **Prepend:** Add a node to the start of the list.
- **Remove:** Delete the first node with a given value.
- **Contains:** Check if a value exists in the list.
- **Print:** Display the list’s contents.

In `Program.cs`, you’ll find three test cases:
- A list of positive numbers (e.g., `1 -> 5 -> 10 -> 15`).
- A list of negative numbers (e.g., `-7 -> -3 -> -1`).
- A mixed list with duplicates (e.g., `0 -> 4 -> 2 -> 4 -> 2`).

Each test demonstrates how the list changes with operations like adding, removing, and searching.

## How to Run
1. Open the project in Rider (I use Rider on my Mac but your preferred C# IDE works too).
2. Ensure all files (`Node.cs`, `CustomLinkedList.cs`, `Program.cs`) are part of the same project.
3. Hit “Run” on `Program.cs`.
4. Check the console output to see the linked lists in action.

## Why This Matters
Linked lists are a stepping stone to understanding more complex data structures like stacks, queues, or trees. By building this yourself, you gain a deeper understanding of how data can be linked dynamically—something that arrays can’t do as easily. It’s a small project, but it’s a significant win for learning!

## Next Steps
Want to dig deeper? Try these on your own:
- **Add a method to count nodes:** Implement a method that returns the total number of nodes in the list.
- **Reverse the list:** Create a method to reverse the order of the nodes.
- **Make it generic (`<T>`):** Update the implementation so it can store any data type.
- **Write Unit Tests:** Integrate unit testing using frameworks like NUnit or MSTest to ensure your methods work correctly.
- **Enhance Error Handling:** Add error handling to manage edge cases, such as removing nodes from an empty list.

## Additional Learning Opportunities
- **Explore Doubly Linked Lists:** Once you’re comfortable with singly linked lists, consider expanding your knowledge by implementing doubly linked lists.
- **Visualize the Structure:** Use visualization tools or draw diagrams to see how nodes connect and change as operations are performed.

Hope you found this to be helpful and informative! If you did, please share with a friend :-)
