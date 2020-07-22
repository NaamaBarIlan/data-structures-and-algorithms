# Daily Code Challenge

## Queue With Stacks
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.

`Enqueue(animal)`: adds an animal to the shelter. animal can be either a dog or a cat object.

---

### Inputs and Expected Outputs

`Enqueue(animal)`:

| Input  | Expected Output |
| :----------- | :----------- | 
| [Cat] | [Cat] |
| [Dog] | [Dog] -> [Cat] |


---

## Approach

- Define an AnimalShelter class

- Define a dog property and a cat property in the Animal Shelter class.

- If the front is null, set the front to the new node

- Else, set the rear to the new node. 
 
---

## Efficiency


### Big O

`Enqueue(animal)`:

| Time | Space |
| :----------- | :----------- |
| O(1) | O(n) |


---


### Whiteboard Visual

![Whiteboard](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CodeChallage12.png)


---

### Change Log 

---

