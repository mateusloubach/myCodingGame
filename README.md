
![banner](/assets/codingame_banner.png)

<div align="center">
  
  ![GitHub top language](https://img.shields.io/github/languages/top/mateusloubach/myCodingGame?style=flat-square&logoColor=f5f5f5&color=%23e4e3e3)
  ![GitHub last commit](https://img.shields.io/github/last-commit/mateusloubach/myCodingGame/main?style=flat-square)
  
  ![GitHub language count](https://img.shields.io/github/languages/count/mateusloubach/myCodingGame?style=flat-square&color=%23e4e3e3)
  ![GitHub Code Size](https://img.shields.io/github/languages/code-size/mateusloubach/myCodingGame?style=flat-square&color=%23e4e3e3)

</div>

A list of definitions in order to keep info organized

## Arrays:
An array is a data structure that allows to store multiple values. Usually, these values share the same type (e.g. integer). Each element of an array is accessed by their index (arr[index] = value).

The access time to an element by index is constant, regardless of the desired element. This is explained by the fact that the array elements are contiguous in memory. Thus, it is possible to calculate the memory address of the element to be accessed, from the base address of the array and the index of the element. Access is immediate, as it would be for a single variable.

This advantage is also one of the limits of such a structure. An array is represented in memory in the form of contiguous cells, insert and delete operations element are impossible, unless you create a new array, larger or smaller (depending on the operation). It is then necessary to copy all elements of the original array into the new one, and then release the memory space allocated to the old array. So that's a lot of operations and require some languages ​​providing such opportunities to implement their own array, not in the traditional form (adjacent cells), but using a linked list, or a combination of both structures to improve performance.

## BFS:
Breadth-first search (BFS) is an algorithm for traversing or searching tree or graph data structures. It starts at the tree root and explores the neighbor nodes first, before moving to the next level neighbors. Thus closer nodes get visited first.
<div align="center">

  ![BFS gif](/assets/bfs.gif)

</div>


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

## Distances:

Distance is a numerical description of how far apart objects are. In physics or everyday usage, distance may refer to a physical length, or an estimation based on other criteria. In most cases, "distance from A to B" is interchangeable with "distance between B and A".

The distance between (x1, y1) and (x2, y2) is given by:

``` d=sqrt((x2-x1)² + (y2-y1)²) ``` 

## Encoding:

In communications and information processing, encoding is a system of rules to convert information—such as a letter, word, sound, image, or gesture—into another form or representation, sometimes shortened or secret, for communication through a channel or storage in a medium.

The process of encoding converts information from a source into symbols for communication or storage. Decoding is the reverse process, converting code symbols back into a form that the recipient understands.

A Caesar cipher, also known as Caesar's code, is one of the simplest and most widely known encryption techniques. It is a type of substitution cipher in which each letter in the plaintext is replaced by a X-shifted letter in the alphabet.

**Cipher with a shift of X=3** 

<div align="center">

  ![Encoding Image](/assets/encoding.png)

</div>


## Flood Fill:
Flood fill, also called seed fill, is an algorithm that determines the area connected to a given node in a multi-dimensional array. It is used in the "bucket" fill tool of paint programs to fill connected, similarly-colored areas with a different color, and in games such as Go and Minesweeper for determining which pieces are cleared.


**FloodFill with 4 directions** 
<div align="center">

  ![FloodFill4](/assets/Recursive_Flood_Fill_4.gif)

</div>

**FloodFill with 8 directions** 

<div align="center">

  ![FloodFill8](/assets/Recursive_Flood_Fill_8.gif)

</div>

## Graph:

In computer science, a graph is an abstract data type that is meant to implement the undirected graph and directed graph concepts from mathematics.

A graph data structure consists of a finite (and possibly mutable) set of vertices or nodes or points, together with a set of unordered pairs of these vertices for an undirected graph or a set of ordered pairs for a directed graph.

A graph data structure may also associate to each edge some edge value, such as a symbolic label or a numeric attribute (cost, capacity, length, etc.).

## Hash Tables:
In computing, a hash table (hash map) is a data structure used to implement an associative array, a structure that can map keys to values. A hash table uses a hash function to compute an index into an array of buckets or slots, from which the desired value can be found.

In many situations, hash tables turn out to be more efficient than search trees or any other table lookup structure. For this reason, they are widely used in many kinds of computer software, particularly for associative arrays, database indexing, caches, and sets.

## Lists:

In computer science, a list or sequence is an abstract data type that represents an ordered sequence of values, where the same value may occur more than once.

An instance of a list is a computer representation of the mathematical concept of a finite sequence; the infinite analog of a list is a stream. Lists are a basic example of containers, as they contain other values. If the same value occurs multiple times, each occurrence is considered a distinct item.

## Loops:

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

# Machine Learning:

Machine learning is the subfield of computer science that "gives computers the ability to learn without being explicitly programmed" (Arthur Samuel, 1959). Evolved from the study of pattern recognition and computational learning theory in artificial intelligence, machine learning explores the study and construction of algorithms that can learn from and make predictions on data – such algorithms overcome following strictly static program instructions by making data-driven predictions or decisions, through building a model from sample inputs. Machine learning is employed in a range of computing tasks where designing and programming explicit algorithms is unfeasible; example applications include spam filtering, optical character recognition (OCR), search engines and computer vision.

Machine learning is closely related to (and often overlaps with) computational statistics, which also focuses in prediction-making through the use of computers. It has strong ties to mathematical optimization, which delivers methods, theory and application domains to the field. Machine learning is sometimes conflated with data mining, where the latter subfield focuses more on exploratory data analysis and is known as unsupervised learning.

## Minimax:
Minimax (sometimes MinMax or MM) is a decision rule used in decision theory, game theory, statistics and philosophy for minimizing the possible loss for a worst case (maximum loss) scenario. Originally formulated for two-player zero-sum game theory, covering both the cases where players take alternate moves and those where they make simultaneous moves, it has also been extended to more complex games and to general decision-making in the presence of uncertainty.

The algorithm reviews all possibilities for a limited number of step and assign a value that takes into account the benefits for the player and for his opponent. Then the best choice is the one that minimizes the loss of any player assuming the adversary seeks instead to maximize (the game is zero-sum).

There are various algorithms based on MinMax to optimize the search for the best shot by limiting the number of nodes visited in the game tree, the best known is pruning alpha-beta. In practice, the tree is often too large to be fully explored (like chess or go). Only a fraction of the tree is explored.

## Multi-Agent System

A multi-agent system (M.A.S.) is a computerized system composed of multiple interacting intelligent agents within an environment. Multi-agent systems can be used to solve problems that are difficult or impossible for an individual agent or a monolithic system to solve. Intelligence may include some methodic, functional, procedural approach, algorithmic search or reinforcement learning.

On CodinGame, a multi-agent game is a game where you can control several characters/units separately to achieve a common goal.

## Neural Network:

In ```machine learning``` and cognitive science, an artificial neural network (ANN) is a network inspired by biological neural networks (the central nervous systems of animals, in particular the brain) which are used to estimate or approximate functions that can depend on a large number of inputs that are generally unknown. Artificial neural networks are typically specified using three things:

Architecture: Specifies what variables are involved in the network and their topological relationships—for example the variables involved in a neural network might be the weights of the connections between the neurons, along with activities of the neurons

Activity Rule: Most neural network models have short time-scale dynamics: local rules define how the activities of the neurons change in response to each other. Typically the activity rule depends on the weights (the parameters) in the network.

Learning Rule: The learning rule specifies the way in which the neural network's weights change with time. This learning is usually viewed as taking place on a longer time scale than the time scale of the dynamics under the activity rule. Usually the learning rule will depend on the activities of the neurons. It may also depend on the values of the target values supplied by a teacher and on the current value of the weights.

For example, a neural network for handwriting recognition is defined by a set of input neurons which may be activated by the pixels of an input image. After being weighted and transformed by a function (determined by the network's designer), the activations of these neurons are then passed on to other neurons. This process is repeated until finally, the output neuron that determines which character was read is activated.

Like other machine learning methods – systems that learn from data – neural networks have been used to solve a wide variety of tasks, like computer vision and speech recognition, that are hard to solve using ordinary rule-based programming.

**NN Representation** 

<div align="center">

  ![NeuralNetworkImage](/assets/neural_network.png)

</div>

## Optimization:

In computer science, program optimization or software optimization is the process of modifying a software system to make some aspect of it work more efficiently or use fewer resources.

On CodinGame, optimization games are games in which you have to maximize the criterion (fuel, output size, score) to climb in the rankings.

## Simulation:

A computer simulation is a simulation, run on a single computer, or a network of computers, to reproduce behavior of a system.

On CodinGame, this kind of puzzle often needs a rewrite of the game engine, so your code will be able to anticipate the game state several turns in advance and take the best decision.

## Strings:

A string is a data type used in programming, such as an integer and floating point unit, but is used to represent text rather than numbers. It is comprised of a set of characters that can also contain spaces and numbers.

For example, the word "puzzle" and the phrase "I love CodinGame" are both strings. Even "12345" could be considered a string, if specified correctly. Typically, programmers must enclose strings in quotation marks for the data to recognized as a string and not a number or variable name.

## Trigonometry:

Trigonometry is a branch of mathematics that studies relationships involving lengths and angles of triangles and trigonometric functions such as sine, cosine and tangent.

<div align="center">

  ![Trigonometry](/assets/trigonometry.gif)

</div>

## Resource Management:

Many games involve the management of resources. Examples of game resources include tokens, money, land, natural resources, human resources and game points. The game will have rules that determine how players can increase, spend, or exchange their various resources.

A skillful management of resources under such rules allows players to influence the outcome of the game.