# Traversals of Data Structures

## Table Of Contents

1. [Linked Lists](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#linked-lists)
2. [Stacks](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#stacks)
3. [Queues](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#queues)
4. [Binary Tree](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#binary-tree)
5. [Binary Search Tree](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#binary-search-tree)
6. [Hashtables](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#hashtables)
7. [Hashsets](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#hashsets)

### Excercises

* Find a value
* Add all the values
* Remove a value

---

## Linked Lists

### Basic Terms:

* **Head** - The Head is a reference type of type Node to the first node in a linked list.
* **Node** - Nodes are the individual items/links that live in a linked list. Each node contains the data for each link.
* **Linked List** - A data structure that contains nodes that links/points to the next node in the list.
* **Singly** - Singly refers to the number of references the node has. A Singly linked list means that there is only one reference, and the reference points to the Next node in a linked list.
* **Doubly** - Doubly refers to there being two (double) references within the node. A Doubly linked list means that there is a reference to both the Next and Previous node.
* **Next** - Each node contains a property called Next. This property contains the reference to the next node.
* **Current** - The Current reference is a reference type of type Node that is currently being looked at. This node is traditionally used when traversing through a full linked list. When traversing, you typically reset the current to the head to guarantee you are starting from the beginning of the linked list.

### Iterative Traversal:

#### Code:

```

while(current != null)
{
	result = [evaluation logic]
	current = current.Next;
}

Return result

```

**Find a value**

```
 public Node FindAValueInLL(LinkedList linkedList, int inputValue)
 {
	Node current = linkedList.Head;

    while(current != null)
    {
        if (current.Value == inputValue)
        {
			return current;
        }

        current = current.Next;        
    }

    return null;
}       

```

#### Visual:


#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | This is because, at its worse case, the node we are looking for will be the very last node in the linked list. n represents the number of nodes in the linked list. |
| Space | O(1) | This is because there is no additional space being used than what is already given to us with the linked list input |
 
### Recursive Traversal:

#### Code:
```
public static void TraverseLL(LinkedList list)
{
    TraverseLL(list.Head);
}

private static void TraverseLL(Node current)
{
    Console.WriteLine(current.Value);

    if (current.Next != null)
    {
        TraverseLL(current.Next);
    }
}
	
```

#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | This is because, at its worse case, the node we are looking for will be the very last node in the linked list. n represents the number of nodes in the linked list. |
| Space | O(1) | This is because there is no additional space being used than what is already given to us with the linked list input |
---

## Stacks

### Basic Terms:

* **Top** - This is the node at the top of the stack.
* **Push** - Nodes or items that are put into the stack are pushed
* **Pop** - Nodes or items that are removed from the stack are popped. When you attempt to pop an empty stack an exception will be raised.
* **Peek** - When you peek you will view the value of the top Node in the stack. When you attempt to peek an empty stack an exception will be raised.
* **IsEmpty** - returns true when stack is empty otherwise returns false.

#### FILO
* First In Last Out - the first item added in the stack will be the last item popped out of the stack.

#### LIFO
* Last In First Out - the last item added to the stack will be the first item popped out of the stack.

**Important! A stack cannot be traversed in place**

### Iterative Traversal:

#### Code:

``` 
Stack stack2 = new Stack();

int sum = 0;

while(Stack.Peek != null) or (!Stack.IsEmpty)
{
	var temp = Stack.Pop() // Pop
	sum += temp.Value      // Evaluate
	Stack2.Push(temp)      // Push/Add
}
```

* The Evaluation can be an array, LL, hashtable, etc. 

#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) |  This is because, at its worse case, the node we are looking for will be at the very bottom of the stack |
| Space | O(n) | This is because the stack cannot be traversed in place and a second stack needs to be instantiated |
 
### Recursive Traversal:

#### Code:

```
Process(Stack)
{
	if(!Stack.Peek())
	{
		return;
	}
	{
		var = Stack.Pop)();
		Process(Stack);
	}
}
```

#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) |  This is because, at its worse case, the node we are looking for will be at the very bottom of the stack |
| Space | O(n) | This is because the stack cannot be traversed in place and a second stack needs to be instantiated |

---

## Queues

### Basic Terms:

* **Front** - This is the front/first Node of the queue.
* **Rear** - This is the rear/last Node of the queue.
* **Enqueue** - Nodes or items that are added to the queue.
* **Dequeue** - Nodes or items that are removed from the queue. If called when the queue is empty an exception will be raised.
* **Peek** - When you peek you will view the value of the front Node in the queue. If called when the queue is empty an exception will be raised.
* **IsEmpty** - returns true when queue is empty otherwise returns false.

#### FIFO
* First In First Out - This means that the first item in the queue will be the first item out of the queue.

#### LILO
* Last In Last Out - This means that the last item in the queue will be the last item out of the queue.

### Iterative Traversal:

#### Code:

```
// In Place:
if (queue.Peek != null)
{
	var first = Front
}
do
{
	// Remove node from the front of the queue:
	var temp = queue.Dequeue();

	// EVAL 
	temp = ?;

	// Add the node to the back of the queue:
	queue.Enqueue(temp);
}
while(Front != First)

=================================================

// Not In Place

while (queue.Peek)
{
	// DQ:
	value = queue.Dequeue();

	// EVAL
	value = ?;
}

```

#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | This is because, at its worse case, the node we are looking for will be at the very rear of the queue |
| Space | O(1) | This is because we are traversing the queue in place, so no new space needs to be allocated |

---

### Recursive Traversal:

#### Code:
```
process (queue)
{
	if (queue.Peek != null)
	{
		return;
	}

	value = queue.Dequeue();
	process(queue)
}

```
#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | This is because, at its worse case, the node we are looking for will be at the very rear of the queue |
| Space | O(1) | This is because we are traversing the queue in place, so no new space needs to be allocated |

---

## Binary Tree

### Basic Terms:

* **Root** - The root is the first/top Node in the tree
* **Left Child** - The node that is positioned to the left of a root or node
* **Right Child** - The node that is positioned to the right of a root or node
* **Node** - A node is the individual item/data that makes up the data structure
* **Edge** - The edge in a tree is the link between a parent and child node
* **Leaf** - A leaf is a node that does not contain any children
* **Height** - The height of a tree is determined by the number of edges from the root to the bottommost node

### Iterative Traversal - Breadth First:

#### Code:

```
BreadthFirst(Node root)
{
	// Create a new queue
	Queue queue = new Queue();
    
	// NQ the root
	queue.Enqueue(root);

	// As long as the queue isn't empty
	while (queue.peek())
	{
		// DQ the front node and output 
		node front = queue.dequeue()
		output front.value

		// NQ Left
		if (front.left != null)
		queue.enqueue(front.left)

		// NQ Right
		if (front.right != null)
		queue.enqueue(front.right)
	}
}
```
  

#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | Since we visit each node in a breadth-first traversal once, the time it will take to read every node depends on the number of nodes in the tree |
| Space | O(w) | The space complexity of a breadth-first traversal is O(w) where w equals the width of the tree. In the worst case situation, we could enqueue all the nodes in a tree if they are all children of one another. |

--- 

### Recursive Traversal - Depth First:

#### Pre-Order Traversal:
#### Code:

```
Public TreeTraversal(Tree tree)
{
	var result = TreeTraversal(tree.Root);
	return result;
}

Private TreeTraversal(Node root)
{
	// ROOT
    Evaluation(root.Value);

    // LEFT
    if (root.LeftChild != null)
    {
		TreeTraversal(root.LeftChild);
    }        

    // RIGHT
    if (root.RightChild != null)
    {
		TreeTraversal(root.RightChild);
    }                      
}
```

#### Visual:

#### In-Order Traversal:

#### Code:

```
Public TreeTraversal(Tree tree)
{
	var result = TreeTraversal(tree.Root);
	return result;
}

Private TreeTraversal(Node root)
{
    // LEFT
    if (root.LeftChild != null)
    {
		TreeTraversal(root.LeftChild);
    }        

	// ROOT
    Evaluation(root.Value);

    // RIGHT
    if (root.RightChild != null)
    {
		TreeTraversal(root.RightChild);
    }                      
}
```

#### Visual:

#### Post-Order Traversal:

#### Code:

```
Public TreeTraversal(Tree tree)
{
	var result = TreeTraversal(tree.Root);
	return result;
}

Private TreeTraversal(Node root)
{
    // LEFT
    if (root.LeftChild != null)
    {
		TreeTraversal(root.LeftChild);
    }        

    // RIGHT
    if (root.RightChild != null)
    {
		TreeTraversal(root.RightChild);
    }              
	
	// ROOT
    Evaluation(root.Value);
}
```
#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(h) | Where h equals the hight of the tree.  In the worst case, we will have to search all the way down to a leaf, which will require searching through as many nodes as the tree is tall  |
| Space | O(1) | During a search, we are not allocating any additional space  |

---

## Binary Search Tree

### Basic Terms: 
* BST Organization: 
	* All values that are smaller than the root are placed to the left of the root. 
	* All values that are larger than the root are placed to the right of the root.

### Iterative Traversal

* **Use a WHILE loop to traverse a BST!**

#### Code:

```
BinarySearchTreeTraversal(Node root)
{
	// The value we're searching for:
	int target = 100;
	Node current = root;

	// Check if the root equals to the target value:
	if (current.value == target)
	{
		return true;
	}

	// While the node has children, isn't a leaf.
	while (current.LeftChild != null && current.RightChild != null)
	{
		// Check if the value equals the target
		if (current.value == target)
		{
			return true;
		}

		// If the value is greater than the target, set the current to left child
		if (current.value > target)
		{
			current = current.LeftChild
		}

		// If the value is smaller than the target, set the current to the right child
		if (current.value < target )
		{
			current = current.RightChild
		}
	}
}
```

#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(h) | The Big O time complexity of a Binary Search Tree’s insertion and search operations is O(h), or O(height). In the worst case, we will have to search all the way down to a leaf, which will require searching through as many nodes as the tree is tall. |
| Space | O(1) | The Big O space complexity of a BST search would be O(1). During a search, we are not allocating any additional space. |

--- 

### Recursive Traversal

#### Code:
#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |

---

## Hashtables

### Basic Terms: 

* **Hash** - A hash is the result of some algorithm taking an incoming string and converting it into a value that could be used for either security or some other purpose. In the case of a hashtable, it is used to determine the index of the array.
* **Buckets** - A bucket is what is contained in each index of the array of the hashtable. Each index is a bucket. An index could potentially contain multiple key/value pairs if a collision occurs.
* **Collisions** - A collision is what happens when more than one key gets hashed to the same location of the hashtable.
* **Add()**  - adds a new key/value pair to a hashtable. How collisions are handled depends on the implementation. 
* **Find()** - takes in a key, gets the Hash, and goes to the index location specified. Once the index location is found in the array, it is then the responsibility of the algorithm to iterate through the bucket and see if the key exists and return the value.
* **Contains()** - accept a key, and return a bool on if that key exists inside the hashtable. 
* **GetHash()** - accept a key as a string, conduct the hash, and then return the index of the array where the key/value should be placed.

#### Code:

```
//	CREATE a hashtable with 10 buckets: 
HashTbl<int> table = new HashTbl<int>(10);

// HASH a key:
int index = GetHash(key);

// ADD elements to a hashtable:
.Add(string key, T value)

table.Add("Josie", 9);
table.Add("Dog", 10);
table.Add("Cupcake", 5);

// FIND an element in a hashtable:
var result = table.Find("Dog");

// CHECK if a hashtable contains an element:
bool contains = table.Contains("Cupcake");

```


#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(1) | O(1) for the lookup of the table, plus the big O of data structure inside the bucket, For example, a LL in a bucket would be O(n)  |
| Space | O(1) - O(n) | If the hashtable exists, during a search we are not allocating any additional space. If a Hashtable needs to be created it'll require as much space as the number of key-value pairs, or O(n)  |

---

## Hashsets

### Basic Terms: 

* First Come First Serve
* The elements must be unique. Duplicate elements are not allowed.
* You can only store elements of the same type.
* **.Add** - returns true if the element is added to the HashSet; false if the element is already present.
* ** .Contains** - returns true if the HashSet contains the specified element; otherwise, false.
* **.Count** - returns the number of elements in the Hashset;
* **.Remove** - returns true if the element is successfully found and removed; otherwise, false.

#### Code:

```
// CREATE a HashSet 

HashSet<int> hashset = new HashSet<int>(); 

// ADD elements to the HashSet:

hashset.Add(4);
hashset.Add(8);
hashset.Add(15);
hashset.Add(16);

// hashset.Add(4) => returns false;

// COUNT the number of elements in the Hashset:
hashset.Count;

// DISPLAY all elements:
foreach(var item in hashset)
{
	Console.WriteLine(item);
}

// REMOVE an element:
hashset.Remove(4);
```

#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(1) | This is because calculating the hash code and index lookup is all constant time |
| Space | O(1) - O(n) | If the hashset exists, during a search we are not allocating any additional space. If a hashset needs to be created it'll require as much space as the number of elements, or O(n)  |


---