# Merge Sort

Merge Sort is an efficient, general-purpose, comparison-based sorting algorithm. Most implementations produce a stable sort, which means that the order of equal elements is the same in the input and output. 

Merge sort is a divide and conquer algorithm which works as follows:

Divide the unsorted list into n sublists, each containing one element (a list of one element is considered sorted).
Repeatedly merge sublists to produce new sorted sublists until there is only one sublist remaining. This will be the sorted list.

## Pseudocode

```ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```


## Trace

Sample Array: `[8,4,23,42,16,15]`

#### Step 1:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC27-1.png)

In the first step of the merge sort we first find the middle of the sample array and split it into 2 sub-arrays: left and right: 
Left Array[8, 4, 23]
Right Array[42, 16, 15]

#### Step 2:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC27-2.png)

Since the merge sort algorithm is using recursion, we will continue to split the two sub-arrays down the middle into a left sub-array and a right sub-array:
Left Array[8, 4, 23] is split into LA[8] and RA[4, 23].
Right Array[42, 16, 15] is split into LA[42] and RA[15, 16].


#### Step 3:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC27-3.png)

The third step will split the last two sub-arrays with a length that is greater than 1 into two left and right sub-arrays of length 1. This is the end of the recursive splitting of the arrays:
RA[4, 23] is split into LA[4] and RA[23].
RA[15, 16] is split into LA[16] and RA[15].

#### Step 4:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC27-4.png)

The 4th step sorts the smallest sub-arrays of 1 and merges them back into their parent array:
LA[4] and RA[23] are sorted back in the same order RA[4, 23].
LA[16] and RA[15] are sorted back in and switch places in RA[15, 16].


#### Step 5:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC27-5.png)

The 5th step sorts the sorted sub-arrays from step 4 with the sub-arrays of 1 element and merges them back into the their parent array:
LA[8] and RA[4, 23] are sorted back into Left Array[4, 8, 23].
LA[42] and RA[15, 16] are sorted back int Right Array[15, 16, 42].

#### Step 6:
![Image](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC27-6.png)

On the final step the sorted Left Array [4, 8, 23] and sorted Right Array [15, 16, 42] are sorted and merged back into the original sample array [4, 8, 15, 16, 23, 42].

This completes the sorting of all of the items in the sample array. 


## Efficency
  * Time: O(nlgn) 
    * This is a divide and conquer algorithm which always divides the array into two halves. 

  * Space: O(n)
     * A merge sort does not sort in place and requires additional storage space for the elements. 
    
