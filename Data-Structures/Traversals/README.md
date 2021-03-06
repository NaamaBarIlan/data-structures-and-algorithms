# Traversals of Data Structures

## Table Of Contents

1. [Linked Lists](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#linked-lists)
2. [Stacks](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#stacks)
3. [Queues](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#queues)
4. [Binary Tree](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#binary-tree)
5. [Binary Search Tree](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#binary-search-tree)
6. [Hashtables](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#hashtables)
7. [Hashsets](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#hashsets)
8. [Heaps](https://github.com/NaamaBarIlan/data-structures-and-algorithms/tree/master/Data-Structures/Traversals#Heaps)


### Reading
1. [Linked Lists](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-05/resources/singly_linked_list.html)
2. [Stacks & Queues](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-10/resources/stacks_and_queues.html)
3. [Trees](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-15/resources/Trees.html)
4. [Hashtables](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-30/resources/Hashtables.html)
5. [Graphs](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-35/resources/graphs.html)

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

public static int CountLLNodes(LinkedList list)
{
	int counter = o;
	
	Node current = list.Head;

	while(current != null)
	{
		counter++;
		current = current.Next;
	}

	return counter;
}


```

**Find a value**

```
 public Node FindAValueInLL(LinkedList list, int value)
 {
    Node current = list.Head;

    while(current != null)
    {
        if(current.Value == value)
        {
		return current;
        }

        current = current.Next;        
    }

    return null;
}       

```

**Walker and Runner**

```
public int FindKthFromEnd(LinkedList list, int key)
{
    // create 2 references:
    Node walker = list.Head;
    Node runner = list.Head;

    // runner to iterate k number of position within the linked list
    int k = key;
    while (k > 0)
    {
        if(runner.Next != null)
        {
            k--;
            runner = runner.Next;
        }
        else
        {
            throw new Exception("K is invalid");
        }
    }

    while(runner.Next != null)
    {
        walker = walker.Next;
        runner = runner.Next;
    }

    return walker.Value;
}
```

```
public static int CountDuplicateLLNodes(LinkedList list)
{
	int counter = 0;

	Node walker = list.Head;

		Node runner = list.Head;

	while(walker.Next != null)
	{
		while(runner.Next != null)
		{
			runner = runner.Next;

			if(runner.Value == walker.Value)
			{
				counter++;
			}

		}

		walker = walker.Next;
		runner = walker;   
	}

	return counter;
}
```

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | At its worse case, the node we are looking for will be the very last node in the linked list. n represents the number of nodes in the linked list. |
| Space | O(1) | There is no additional space being used other than what is already given to us with the linked list input |
 
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

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | At its worse case, the node we are looking for will be the very last node in the linked list. n represents the number of nodes in the linked list. |
| Space | O(1) | There is no additional space being used than what is already given to us with the linked list input |

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

**A stack cannot be traversed in place!**

### Iterative Traversal:

#### Code:

``` 
public int StackTraversal(Stack stack1)
{
	Stack stack2 = new Stack();

	int sum = 0;

	while(stack1.Peek != null) 
	{
		// POP
		Node temp = stack1.Pop(); 

		// EVAL
		sum += temp.Value; 
	
		// PUSH
		stack2.Push(temp);     
	}

	return sum;
}

```

* The Evaluation can be an array, LL, hashtable, etc. 

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) |  At its worse case, the node we are looking for will be at the very bottom of the stack |
| Space | O(n) | The stack cannot be traversed in place and a second stack needs to be instantiated |
 
### Recursive Traversal:

#### Code:

```
public Node StackTraversalRec(Stack stack)
{
	if(stack.IsEmpty())
	{
		return null;
	}

	// EVAL
	Node removed = stack.Pop();

	if(stack.IsEmpty())
	{
		return removed;
	}

	return StackTraversal(stack);
}
```

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) |  At its worse case, the node we are looking for will be at the very bottom of the stack |
| Space | O(n) | The stack cannot be traversed in place and a second stack needs to be instantiated |

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

* **In Place**

```
public int InPlaceQueTraversal(Queue que)
{
	int first = 0;

	if(que.Peek != null)
	{
		first = que.Front;
	}

	do
	{
		// Remove node from the front of the queue:
		var temp = que.Dequeue();

		// EVAL 
		Console.WriteLine(temp.Value);

		// Add the node to the back of the queue:
		que.Enqueue(temp);
	}
	while(que.Front != first);

	return first;
}

```

* **Destructive**

```
public static int FindMinInQueue(Queue que)
{
	if(que.Peek == null)
	{
		return null;
	}
	
	int temp = que.Dequeue;
	
	while(que.Peek != null)
	{
		int front = que.Dequeue;
		
		if(temp > front)
		{
			temp = front;
		}
	}
	
	return temp;
}

```

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | At its worse case, the node we are looking for will be at the very rear of the queue |
| Space | O(1) | The queue is being traversed in place, so no new space needs to be allocated |

---

### Recursive Traversal:

#### Code:
```

public static int SumQueElements(Queue que)
{
	int sum = 0;
	
	return SumQueElements(que, sum);
} 

private static int SumQueElements(Queue que, int sum)
{
	// Check if the front is null
	if(que.Front == null)
	{
		return sum;
	}
	
	// DQ the front
	int front = que.Dequeue;
	
	// EVAL front
	sum += front;
	
	// RECURSION
	return SumQueElements(que, sum);
}

```

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | At its worse case, the node we are looking for will be at the very rear of the queue |
| Space | O(1) | The queue is being traversed in place, so no new space needs to be allocated |

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
public static void BreadthFirstTraversal(Node root)
{
	// Instantiate a new queue
	Queue que = new Queue();
    
	// NQ the root
	que.Enqueue(root);

	// As long as the queue isn't empty:
	while(que.Peek() != null)
	{
		// DQ the front node and output 
		Node front = que.Dequeue();

		ConsoleWriteLine(front.Value);

		// NQ Left Child
		if(front.LeftChild != null)
		{
			que.Enqueue(front.LeftChild);
		}
		
		// NQ Right Child
		if(front.RightChild != null)
		{
			que.Enqueue(front.RightChild);
		}
	}
}
```
  
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | Since each node is visited in a breadth-first traversal once, the time it will take to read every node depends on the number of nodes in the tree |
| Space | O(w) | The space complexity of a breadth-first traversal is O(w) where w equals the width of the tree. In the worst case situation, we could enqueue all the nodes in a tree if they are all children of one another. |

--- 

### Recursive Traversal - Depth First:

#### Pre-Order Traversal:
#### Code:

```
public List<T> PreOrder(Node<T> root)
{
    List<T> list = new List<T>();
    PreOrder(list, root);
    return list;
}

private void PreOrder(List<T> list, Node<T> root)  
{
	// ROOT - EVAL 
    list.Add(root.Value);

    // LEFT
    if(root.LeftChild != null)
    {
        PreOrder(list, root.LeftChild);
    }       

	// RIGHT
    if(root.RightChild != null)
    {
        PreOrder(list, root.RightChild);
    }                      
}
```

#### In-Order Traversal:

#### Code:

```
public List<T> InOrder(Node<T> root)
{
    List<T> traversal = new List<T>();
    InOrder(traversal, root);
    return traversal;
}

private void InOrder(List<T> list, Node<T> root)
{
    // LEFT
    if(root.LeftChild != null)
    {
        InOrder(list, root.LeftChild);
    }        

	// ROOT - EVAL
    list.Add(root.Value);

    // RIGHT
    if(root.RightChild != null)
    {
        InOrder(list, root.RightChild);
    }                     
}
```

#### Post-Order Traversal:

#### Code:

```
public List<T> PostOrder(Node<T> root)
{
    List<T> list = new List<T>();
    PostOrder(list, root);
    return list;
}

private void PostOrder(List<T> list, Node<T> root)
{
	// LEFT
    if(root.LeftChild != null)
    {
        PostOrder(list, root.LeftChild);
    }

	// RIGHT
    if(root.RightChild != null)
    {
        PostOrder(list, root.RightChild);
    }

	// ROOT - EVAL
    list.Add(root.Value);
}
```

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(h) | Where h equals the hight of the tree.  In the worst case, we will have to search all the way down to a leaf, which will require searching through as many nodes as the tree is tall  |
| Space | O(1) | During a search, there is no need for allocating any additional space  |

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
BinarySearchTreeTraversal(Node root, int target)
{
	Node current = root;

	// Check if the root equals to the target value:
	if (current.Value == target)
	{
		return true;
	}

	// While the current node is not null:
	while (current != null)
	{
		// Check if the value equals the target
		if (current.Value == target)
		{
			return true;
		}

		// If the target is smaller than the value of current, set the current to the left child:
		if (target < current.Value)
		{
			current = current.LeftChild;
		}

		// If the target is greater than the value of current, set the current to the right child:
		if (target > current.Value)
		{
			current = current.RightChild;
		}
	}

	// If the value wasn't found in any of the nodes:
	return false;
}
```

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(h) | The Big O time complexity of a Binary Search Tree's insertion and search operations is O(h), or O(height). In the worst case, we will have to search all the way down to a leaf, which will require searching through as many nodes as the tree is tall. |
| Space | O(1) | The Big O space complexity of a BST search would be O(1). During a search, we are not allocating any additional space. |


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
* **.Contains** - returns true if the HashSet contains the specified element; otherwise, false.
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

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(1) | This is because calculating the hash code and index lookup is all constant time |
| Space | O(1) - O(n) | If the hashset exists, during a search we are not allocating any additional space. If a hashset needs to be created it'll require as much space as the number of elements, or O(n)  |


---

---

## Heaps

### Basic Terms: 
