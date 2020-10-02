# Daily Code Challenge

---

## Reverse Integer
*Author: Na'ama Bar-Ilan*



---

### Problem Domain

* Given a 32-bit signed integer, reverse digits of an integer.
* Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [?231,  231 ? 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

* [*Link to LeetCode problem*](https://leetcode.com/problems/reverse-integer/)

---

### Inputs and Expected Outputs

| Input | Expected Output |
| :-----------: | :-----------:  |
| 123  | 321  |
|  -123 | -321  |
|  120 | 21  |

---

### Big O


| Efficiency  | Big O |  |
| :-----------: | :-----------: |  :----------- |
| Time |  O(n)  | This is because we are traversing an entire string that grows as the number of digits in the input grows |
| Space| O(n) | This is because we are instantiating a new output char array that will be as large as the number of digits in our input number |

---

### Change Log
1.1 *Completed challenge and added README* - 1 Oct 2020 <br>
1.0 *Initial project set up* - 28 Sep 2020  

---
