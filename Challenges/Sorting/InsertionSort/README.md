# Insertion Sort

Insertion sort is a simple sorting algorithm that builds the final sorted array (or list) *one item at a time*. It is much less efficient on large lists than more advanced algorithms such as quicksort, heapsort, or merge sort. For small data sets insertion sort provides several advantages: 
* It is a simple implementation. 
* It is more efficient than other simple quadratic algorithms such as selection sort or bubble sort. 
* It is adaptive, meaning, it is efficient for data sets are already somewhat sorted.
* It is stable and does not change the relative order of elements with equal keys.
* It is done in-place and only requires O(1) of additional memory space.
* It is online and can sort a list as it is received.

## Pseudocode

![PseudocodeImage](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC-26-Pseudo.png)

## Trace

Sample Array: `[8,4,23,42,16,15]`

#### Pass 1:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC26-Pass1.png)

In the first pass of the insertion sort we set the key j to index 1, which is 4, and compare it with the previous element in the array, which is 8. 

- Since 8 is greater than 4, we move the element 8 to be in the next position and insert the key 4 into the previous position.

#### Pass 2:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC26-Pass2.png)

The second pass through the array we set the key j to index 2, which is 23, and compare it with the previous element in the array, which is 8. 

- Since 23 is greater than 8, we do not move the element 23 and the array stays in the same order. 

#### Pass 3:
![Image]()

The third pass through the array we set the key j to index 3, which is 42, and compare it with the previous element in the array, which is 23. 

- Since 42 is greater than 23, we do not move the element 42 and the array stays in the same order.

#### Pass 4:
![Image]()

The 4th pass through the array we set the key j to index 4, which is 16, and compare it with the previous element in the array, which is 42. 

- Since 16 is not greater than 42, we insert the element 16 into the previous position. 
- We then compare 16 with the previous element in the array, which is 23, since 16 is not greater than 23 we insert it into the previous position. 
- We then compare 16 with the previous element in the array, which is 8, since 16 is not greater than 8 so exit the while loop. 

#### Pass 5:
![Image]()

On its final iteration through the array we set the key j to index 5, which is 15, and compare it with the previous element in the array, which is 42.

- Since 15 is not greater than 42, we insert the element 15 into the previous position.
- We then compare 15 with the previous element in the array, which is 23, since 15 is not greater than 23 we insert it into the previous position.
- We then compare 15 with the previous element in the array, which is 16, since 15 is not greater than 16 we insert it into the previous position.
- We then compare 15 with the previous element in the array, which is 8, since 15 is greater than 8 we exit the loop. 

This completes the sorting of all of the items in the sample array. 


## Efficency
  * Space: O(1)
    * As Insertion Sort is done in-place it only requires O(1) of additional memory space.
