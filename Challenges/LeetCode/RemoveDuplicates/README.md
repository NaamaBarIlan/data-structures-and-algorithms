# Daily Code Challenge

---

## Remove Duplicates from Sorted Array
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Note that the input array is passed in by reference, which means a modification to the input array will be known to the caller as well.


* [*Link to LeetCode problem*](https://leetcode.com/problems/remove-duplicates-from-sorted-array/)

---

### Inputs and Expected Outputs

**Example 1:**

```
Input: nums = [1,1,2]
Output: 2, nums = [1,2]
Explanation: Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the returned length.
```

**Example 2:**

```
Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4]
Explanation: Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively. It doesn't matter what values are set beyond the returned length.
```

---


### Constraints

* 0 <= nums.length <= 3 * 10<sup>4</sup>
* -10<sup>4</sup> <= nums[i] <= 10<sup>4</sup>
* nums is sorted in ascending order.


### Change Log

1.0 *Initial project set up* - 19 Jan 2021  

---