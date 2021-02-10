
# Daily Code Challenge

---

## Reverse a String
*Author: Na'ama Bar-Ilan*

---

### Problem Domain

Solve the following code challenge in the file:

Reverse a string, 3 different ways

---

### Inputs and Expected Outputs

Input:"This is a string"

Output:"gnirts a si sihT"

Edge cases:

Empty string

1. Arrays

Visual:

Input: "This is a string" 

InputArray
[T,h,i,s, ,i,s, ,a, ,s,t,r,i,n,g]

OutputArray
[g,n,i,r,t,s, ,a, ,s,i, ,s,i,h,T]

Output: "gnirts a si sihT"

Algorithm:
- Create a method that takes in a string as parameter 
- Turn the string into a char array called InputArray
- Declare another char array called OutputArray that is the length of the InputArray
- Loop over the InputArray and assign each char to the OutputArray, but in reverse order, so that the first element in the InputArray becomes the last element in the output array. 
- Turn the char array to a string called result
- Return the result

Pseudo Code:
ALGORITHM ReverseString(string)
//INPUT <- a string
//OUTPUT <- a reversed string

DECLARE Char[] InputArray <- string
DECLARE Char[] OutputArray

for i <- 0, j <- string.length -1, i++, j--
	InputArray[j] = OutputArray[i]

string <- OutputArray

RETURN string

Code:

public string ReverseString(inputString)
{
  char[] InputArray = inputString.ToCharArray();
  char[] OutputArray = new Char[inputString.Length];
  for(int i = 0, j = inputString.Length -1; i < inputString; i++, j--)
  {
     OutputArray[i] = InputArray[j];
  }
  string result = new string(OutPutArray);
  return result;
}

2. Queue

Visual:

Input: "This is a string" 
OutputString: ""

Queue:
[T|h|i|s| |i|s| |a| |s|t|r|i|n|g]

OutputString: "gnirts a si sihT"

Algorithm:
- Create a method that takes in a string as parameter
- Declare an empty OutputString
- For loop over the string and Enqueue each char into the queue
- While loop over the queue, Dequeue and add each char value to the OutputString
- Return the OutputString

Pseudo Code:
ALGORITHM ReverseString(string)
//INPUT <- a string
//OUTPUT <- a reversed string

DECLARE Queue
DECLARE OutputString 

for i <- 0 to string.Length
   Enqueue <- Input[i]

while Front.Peek != null
   Dequeue <- Front
   OutputString <- Add Front

RETURN OutputString 

Code:
public string ReverseString(inputString)
{
  Queue queue = new Queue(); 
  string OutputString = "";
  
  for(i = 0; i < inputString.Length; i++)
  {
    queue.Enqueue(inputString[i]);  
  }
  
  while(Front.Peek != null)
  {
    OutputString += queue.Dequeue(); 
  }
  
  return OutputString;

}


3. Stack

Visual:

Input: "This is a string" 
OutputString: ""

Stack:
-
g
n
i
r
t
s
 
a
 
s
i
 
s
i
h
T
_

OutputString: "gnirts a si sihT"

Algorithm:
- Create a method that takes in a string as parameter
- Declare an empty OutputString
- For loop over the string and push each char onto the stack 
- While loop over the stack, pop the top and add each char value to the OutputString
- Return the OutputString

Pseudo Code:
ALGORITHM ReverseString(string)
//INPUT <- a string
//OUTPUT <- a reversed string

DECLARE Stack
DECLARE OutputString 

for i <- 0 to string.Length
   Push <- Input[i]

while Top.Peek != null
   Pop <- Top
   OutputString <- Add Top

RETURN OutputString 

Code:
{
  Stack stack = new Stack(); 
  string OutputString = "";
  
  for(i = 0; i < inputString.Length; i++)
  {
    stack.Push(inputString[i]);  
  }
  
  while(stack.Peek != null)
  {
    OutputString += stack.Pop(); 
  }
  
  return OutputString;

}

*[This article](https://www.c-sharpcorner.com/UploadFile/19b1bd/reverse-a-string-in-different-ways-using-C-Sharp/) was used to help clarify the Array reverse method.
