# Daily Code Challenge

---

## Binary Search in a Sorted 1D Array
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

* Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. 

* Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

* The search algorithm  used in your function should be a binary search.

---

### Inputs and Expected Outputs

| Input | Expected Output |
| :-----------: | :-----------:  |
| [4,8,15,16,23,42], 15  | 2 |
| [11,22,33,44,55,66,77], 90 | -1 |

---

### Big O


| Efficiency  | Big O |  |
| :-----------: | :-----------: |  :----------- |
| Time |  O(lgn)  | This is because the problem size is cut in half on each iteration |
| Space| O(1) | This is because the sorting is done in place and no new space needs to be allocated  |

---

### Change Log

1.0 *Initial project set up* - 18 Sep 2020  

---
