# Daily Code Challenge

## Tree Intersection
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

* Implement a simplified LEFT JOIN for 2 Hashmaps.

* Write a function that LEFT JOINs two hashmaps into a single data structure.

* The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.

* The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.

* Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.

* LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.

*  The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic.

* Avoid utilizing any of the library methods available to your language.


---

### Inputs and Expected Outputs


![InputImage 1](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC33-IO.png)


---

## Approach

- Create a method that takes in two Hashtables.
- Declare a LeftJoin array.
- Traverse the first(left) Hashtable with a foreach loop.
- Inside the foreach loop create a mini array:
- Add every item or key/value pair from the hashtable to the mini array 
- Look up the key in the second hashtable.
- If the key exists, add its value to the mini array
- If the key does not exist, add the word Null to the mini array. 
- Add the mini array to the main array. 
- Exit the loop - return the LeftJoin array.  


## Efficiency


### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

---


### Whiteboard Visual

![Image 1](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC33.png)


---

### Change Log


1.0 *Initial project set up* - 19 Aug 2020  

---
