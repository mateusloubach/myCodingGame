# myCodingGame

## BFS:
Breadth-first search (BFS) is an algorithm for traversing or searching tree or graph data structures. It starts at the tree root and explores the neighbor nodes first, before moving to the next level neighbors. Thus closer nodes get visited first.


Pseudo-code:

 1    Breadth-First-Search(Graph, root):
 2 
 3     for each node n in Graph:            
 4        n.distance = INFINITY        
 5        n.parent = NIL
 6 
 7     create empty queue Q      
 8 
 9    root.distance = 0
10   Q.enqueue(root)                      
11 
12   while Q is not empty:        
13     
14       current = Q.dequeue()
15     
16       for each node n that is adjacent to current:
17           if n.distance == INFINITY:
18               n.distance = current.distance + 1
19               n.parent = current
20              Q.enqueue(n)



## Graph:
Definition

In computer science, a graph is an abstract data type that is meant to implement the undirected graph and directed graph concepts from mathematics.

A graph data structure consists of a finite (and possibly mutable) set of vertices or nodes or points, together with a set of unordered pairs of these vertices for an undirected graph or a set of ordered pairs for a directed graph.

A graph data structure may also associate to each edge some edge value, such as a symbolic label or a numeric attribute (cost, capacity, length, etc.).

## Lists:
In computer science, a list or sequence is an abstract data type that represents an ordered sequence of values, where the same value may occur more than once.

An instance of a list is a computer representation of the mathematical concept of a finite sequence; the infinite analog of a list is a stream. Lists are a basic example of containers, as they contain other values. If the same value occurs multiple times, each occurrence is considered a distinct item.