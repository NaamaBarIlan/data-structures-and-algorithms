# Daily Code Challenge

---

## Left Join
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

* Find common values in 2 binary trees.

* Write a function called tree_intersection that takes two binary tree parameters.

* Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.

---

### Inputs and Expected Outputs

* **Input:** 

![InputImage 1](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/BT1.png)


![InputImage 2](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/BT2.png)


* **Expected Output:**
`[100,160,125,175,200,350,500]`

---

## Approach

- The function would take 2 BT as parameters.

- Declare an output List

- Declare a Hashtable

- Traverse BT1 and store each node's value as a key in the Hashtable

- Traverse BT2 and for each node, check if the hashtable contains the key. If it does, add the key to the array. 

- Return the array. 

## Efficiency


### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

---


### Whiteboard Visual

![Image 1](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC32.png)



### Change Log

1.1 *Completed Tree Intersection code and 2 passing unit tests* - 29 Aug 2020<br>
1.0 *Initial project set up* - 19 Aug 2020  

---
