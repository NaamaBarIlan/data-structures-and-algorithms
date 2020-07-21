# Daily Code Challenge

## Queue With Stacks
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

Implement a queue using two stacks.

Create a new Queue class called Pseudo Queue that has two methods: Enqueue and Dequeue, using only two Stack objects.

The Enqueue method takes a value parameter and inserts it into the PseudoQueue using a first-in, first-out approach.

The Dequeue method extracts a value from the PseudoQueue, using a first-in, first-out approach.

The Stack instances have only `push`, `pop`, and `peek` methods.
 
---

### Inputs and Expected Outputs

`Enqueue(value)`:

| Input | Args  | Expected Output |
| :----------- | :----------- | :----------- |
| [10]->[15]->[20] | 5 | [5]->[10]->[15]->[20] |
|  | 5 | [5] |

`Dequeue()`:

| Input | Output  | Internal State |
| :----------- | :----------- | :----------- |
| [5]->[10]->[15]->[20] | 20 | [5]->[10]->[15] |
| [5]->[10]->[15] | 15 | [5]->[10] |


---

## Approach

- To Enqueue to the PseudoQueue, simply Push the internal stack.
- To Dequeue the PseudoQueue, first the internal stack needs to be flipped, then its value will be popped off the stack before finally flipping the stack back to the prior orientation.
- The flipping process will be done with a while loop that pushes the popped top of one stack to the other


## Efficiency


### Big O

`Enqueue(value)`:

| Time | Space |
| :----------- | :----------- |
| O(1) | O(1) |

`Dequeue()`:

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


---


### Whiteboard Visual

![Whiteboard](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CodeChallage11.png)


---

### Change Log 

1.1 *Collaborated with Andrew Smith and Peyton Cysewski.* - 20 Jul 2020

---

