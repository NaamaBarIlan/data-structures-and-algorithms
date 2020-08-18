# Daily Code Challenge

## Repeated Word
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

* Find the first repeated word in a book. 

* Write a function that accepts a lengthy string parameter.

* Without utilizing any of the built-in library methods available to your language, return the first word to occur more than once in that provided string.


---

### Inputs and Expected Outputs

| Input | Expected Output |
| :----------- | :----------- |
| `"Once upon a time, there was a brave princess who..."` | `"a"` |
| `"It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."` | `"it"` |
| `"It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."` | `"summer"` |

---

## Approach

* Split the string on a [" ", ",", ".", """] into an array of strings, each of the words in the sentence. 

* Traverse the array and store each element in a Hashtable, with the string as the key.

* If there is a collision, return the key. 

## Efficiency


### Big O


| Time | Space |
| :----------- | :----------- |
| O(nlgn) | O(1) |

---


### Whiteboard Visual

![Image 1](https://github.com/NaamaBarIlan/data-structures-and-algorithms/blob/master/Assets/CC31.png)


---

### Change Log


1.0 *Initial project set up* - 17 Aug 2020  

---
