# Daily Code Challenge

## Multi-bracket Validation
*Author: Na'ama Bar-Ilan*

---

### Problem Domain


A function that should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:

* Round Brackets : `()`
* Square Brackets : `[]`
* Curly Brackets : `{}`

---

### Inputs and Expected Outputs

| Input | Expected Output |
| :----------- | :----------- |
| `{}` | `TRUE` |
| `()[[Extra Characters]]` | `TRUE` |
| `[({}]` | `FALSE` |
| `{(})` | `FALSE` |


---

## Approach

* Declare a new Stack object
* Iterate over the input string
* If a character is an opening bracket, push it to the stack
* Else if a character is a closing bracket and stack.Top is equal to its opening bracket, pop stack.Top.
* Else return false
* If a character is not an opening or a closing that matches the top, return false.
* After the for loop check if the stack is empty, if so return true, else, false.

## Efficiency


### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


---


### Whiteboard Visual

![Image 1](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CodeChallenge13.png)


---

### Change Log

1.3 *Updated BracketValidation method to ignore characters, and created two additional unit tests* - 27 Jul 2020

1.2 *Updated MBracketValidation method and created a happy path unit test* - 26 Jul 2020

1.1 *Collaborated with Bryant Davis.* - 22 Jul 2020  

---
