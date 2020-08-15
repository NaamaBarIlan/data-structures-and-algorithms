# Daily Code Challenge

## Hashtable
*Author: Na'ama Bar-Ilan*

---

## Challenge

Implement a Hashtable with the following methods:

* `add`: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
* `get`: takes in the key and returns the value from the table.
* `contains`: takes in the key and returns a boolean, indicating if the key exists in the table already.
* `hash`: takes in an arbitrary key and returns an index in the collection.

### Included Tests

Adding a key/value to your hashtable results in the value being in the data structure
Retrieving based on a key returns the value stored
Successfully returns null for a key that does not exist in the hashtable
Successfully handle a collision within the hashtable
Successfully retrieve a value from a bucket within the hashtable that has a collision

---

## Approach & Efficiency


| Type | Time | Space |
| :-----------: | :-----------: | :-----------: |
| `add` | O(1) | O(1) |
| `get` | O(1) | O(1) |
| `contains` | O(1) | O(1) |
| `hash` | O(1) | O(1) |

#### Hashtable Time Efficency: 
The hash code is calculated in constant time and writing to an array at one index is O(1) so the hash map has O(1) read access. 

#### Hashtable Space Efficency: 
The space complexity of a hashtable is typically O(n) based on the number of elements it stores.

----

### Change Log

1.1: *Added hashtable and unit tests* - 15 Aug 2020
---

