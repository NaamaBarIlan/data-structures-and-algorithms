# Traversals of Data Structures

## Table Of Contents

1. Linked Lists
2. Stacks
3. Queues
4. Binary Tree
5. Binary Search Tree
6. Hashtables

### Excercises

* Add all the values
* Find a value
* Remove a value

---

## Linked Lists

### Basic Terms:

* *Linked List* - A data structure that contains nodes that links/points to the next node in the list.
* *Singly* - Singly refers to the number of references the node has. A Singly linked list means that there is only one reference, and the reference points to the Next node in a linked list.
* *Doubly* - Doubly refers to there being two (double) references within the node. A Doubly linked list means that there is a reference to both the Next and Previous node.
* *Node* - Nodes are the individual items/links that live in a linked list. Each node contains the data for each link.
* *Next* - Each node contains a property called Next. This property contains the reference to the next node.
* *Head* - The Head is a reference type of type Node to the first node in a linked list.
* *Current* - The Current reference is a reference type of type Node that is currently being looked at. This node is traditionally used when traversing through a full linked list. When traversing, you typically reset the current to the head to guarantee you are starting from the beginning of the linked list.

### Iterative Traversal

#### Code:
```
while(current != null)
{
	result = [evaluation logic]
	current = current.Next;
}

Return result
```

#### Visual:


#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) | This is because, at its worse case, the node we are looking for will be the very last node in the linked list. n represents the number of nodes in the linked list. |
| Space | O(1) | This is because there is no additional space being used than what is already given to us with the linked list input |
 
### Recursive Traversal

#### Code:
```
RecursiveMethod(node)
{
	if (current.Next != null)
	{
		Return
	}
	
	RecursiveMethod(current.Next)
}
	
```

#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |

---

## Stacks

### Basic Terms:

* *Push* - Nodes or items that are put into the stack are pushed
* *Pop* - Nodes or items that are removed from the stack are popped. When you attempt to pop an empty stack an exception will be raised.
* *Top* - This is the top of the stack.
* *Peek* - When you peek you will view the value of the top Node in the stack. When you attempt to peek an empty stack an exception will be raised.
* *IsEmpty* - returns true when stack is empty otherwise returns false.

#### FILO
* First In Last Out
* This means that the first item added in the stack will be the last item popped out of the stack.

#### LIFO
* Last In First Out
* This means that the last item added to the stack will be the first item popped out of the stack.

**A stack cannot be traversed in place**

### Iterative Traversal

#### Code:

``` 
Stack stack2 = new Stack();

int sum = 0;

while(Stack.Peek != null) or (!Stack.IsEmpty)
{
	var temp = Stack.Pop() // Pop
	sum += temp.Value      // Evaluate
	Stack2.Push(temp)      // Pus/Add
}
```

* The Evaluation can be an array, LL, hashtable, etc. 

#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O(n) |  This is because, at its worse case, the node we are looking for will be at the very bottom of the stack |
| Space | O(n) | This is because the stack cannot be traversed in place and a second stack needs to be instantiated |
 
### Recursive Traversal

#### Code:

Process(Stack)
{
	if(!Stack.Peek())
	{
		return
	}
	{
		var = Stack.Pop)();
		Process(Stack);
	}
}

#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |

---

## Queues

### Iterative Traversal

#### Code:
#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |
 
### Recursive Traversal

#### Code:
#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |

---

## Binary Tree

### Iterative Traversal : Breadth First

#### Code:
#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |
 
### Recursive Traversal : Depth First

#### Pre-Order Traversal:
#### Code:
#### Visual:

#### In-Order Traversal:
#### Code:
#### Visual:

#### Post-Order Traversal:
#### Code:
#### Visual:

#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |

---

## Binary Search Tree

### Iterative Traversal

#### Code:
#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |
 
### Recursive Traversal

#### Code:
#### Visual:
#### Big O:

| Efficiency  | Big O | Analysis |
| :-----------: | :-----------: |:-----------: |
| Time | O() |  |
| Space | O() |  |

---