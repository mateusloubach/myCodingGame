# myCodingGame

## BFS:
Breadth-first search (BFS) is an algorithm for traversing or searching tree or graph data structures. It starts at the tree root and explores the neighbor nodes first, before moving to the next level neighbors. Thus closer nodes get visited first.

[![BFS gif](/assets/bfs.gif)

Pseudo-code:
```
Breadth-First-Search(Graph, root):
  
for each node n in Graph:            
n.distance = INFINITY        
n.parent = NIL

create empty queue Q      

root.distance = 0
Q.enqueue(root)                      
 
while Q is not empty:        

current = Q.dequeue()

for each node n that is adjacent to current:

if n.distance == INFINITY:
n.distance = current.distance + 1
n.parent = current
Q.enqueue(n)
```


## Graph:

In computer science, a graph is an abstract data type that is meant to implement the undirected graph and directed graph concepts from mathematics.

A graph data structure consists of a finite (and possibly mutable) set of vertices or nodes or points, together with a set of unordered pairs of these vertices for an undirected graph or a set of ordered pairs for a directed graph.

A graph data structure may also associate to each edge some edge value, such as a symbolic label or a numeric attribute (cost, capacity, length, etc.).

## Lists:

In computer science, a list or sequence is an abstract data type that represents an ordered sequence of values, where the same value may occur more than once.

An instance of a list is a computer representation of the mathematical concept of a finite sequence; the infinite analog of a list is a stream. Lists are a basic example of containers, as they contain other values. If the same value occurs multiple times, each occurrence is considered a distinct item.

## Arrays:

An array is a data structure that allows to store multiple values. Usually, these values share the same type (e.g. integer). Each element of an array is accessed by their index (arr[index] = value).

The access time to an element by index is constant, regardless of the desired element. This is explained by the fact that the array elements are contiguous in memory. Thus, it is possible to calculate the memory address of the element to be accessed, from the base address of the array and the index of the element. Access is immediate, as it would be for a single variable.

This advantage is also one of the limits of such a structure. An array is represented in memory in the form of contiguous cells, insert and delete operations element are impossible, unless you create a new array, larger or smaller (depending on the operation). It is then necessary to copy all elements of the original array into the new one, and then release the memory space allocated to the old array. So that's a lot of operations and require some languages ​​providing such opportunities to implement their own array, not in the traditional form (adjacent cells), but using a linked list, or a combination of both structures to improve performance.


## Loop:

In computer science, a loop is a programming structure that repeats a sequence of instructions until a specific condition is met. Programmers use loops to cycle through values, add sums of numbers, repeat functions, and many other things.

Loops are supported by all modern programming languages, though their implementations and syntax may differ. Two of the most common types of loops are the while loop and the for loop.

The for-loop:

```
FOR I = 1 TO N
    -- do some stuff
NEXT I
```

The while-loop:

```
WHILE (boolean condition) THEN
    -- do some stuff
LOOP
```

## Conditions:

In programmation, conditional expressions are features of a programming language, which perform different computations or actions depending on whether a programmer-specified boolean condition evaluates to true or false.

The if–then-else construct is common across many programming languages. Although the syntax varies quite a bit from language to language, the basic structure (in pseudocode) looks like this:
```
If (boolean condition) Then
     -- do some stuff
Else
     -- do other stuff
End If
```
When an interpreter finds an If, it expects a boolean condition – for example, x > 0, which means "the variable x contains a number that is greater than zero" – and evaluates that condition. If the condition is true, the statements following the “then” are executed. Otherwise, the execution continues in the following branch – either in the else block (which is usually optional), or if there is no else branch, then after the end If.

## Encoding:

In communications and information processing, encoding is a system of rules to convert information—such as a letter, word, sound, image, or gesture—into another form or representation, sometimes shortened or secret, for communication through a channel or storage in a medium.

The process of encoding converts information from a source into symbols for communication or storage. Decoding is the reverse process, converting code symbols back into a form that the recipient understands.

A Caesar cipher, also known as Caesar's code, is one of the simplest and most widely known encryption techniques. It is a type of substitution cipher in which each letter in the plaintext is replaced by a X-shifted letter in the alphabet.

** Cipher with a shift of X=3** 

[![Encoding Image](/assets/encoding.png)
