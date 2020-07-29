# Daily Code Challenge

## Trees
*Author: Na'ama Bar-Ilan*

---

## Challenge

* Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.

* Create a BinaryTree class
	* Define a method for each of the depth first traversals called `PreOrder`, `InOrder`, and `PostOrder` which returns an array of the values, ordered appropriately.

* Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.

* Write an instance method called `FindMaximumValue`. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.


* Create a BinarySearchTree class
	* Define a method named `Add` that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
	* Define a method named `Contains` that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

### Included Tests

1. Can successfully instantiate an empty tree
2. Can successfully instantiate a tree with a single root node
3. Can successfully add a left child and right child to a single root node
4. Can successfully return a collection from a preorder traversal
5. Can successfully return a collection from an inorder traversal
6. Can successfully return a collection from a postorder traversal

---

## Approach & Efficiency


| Type | Time | Space |
| :----------- | :----------- | :----------- |
| `PreOrder`, `InOrder`, `PostOrder` | O(n) | O(h) |
| `FindMaximumValue` | O(n) | O(1) |

#### BinaryTree Time Efficency 
As we are traversing the entire tree in all of the BinaryTree methods, the Big O time complexity is O(n).
 
#### BinaryTree Space Efficency 
The space complexity of a Binary tree is determined by its height.

---

## API

* tree.PreOrder()
* tree.InOrder()
* tree.PostOrder()
* tree.FindMaximumValue()

----

### Change Log


---

