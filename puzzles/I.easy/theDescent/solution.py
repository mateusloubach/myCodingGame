# The Descent - solution in Python

import sys
import math

# The while loop represents the game.
# Each iteration represents a turn of the game
# where you are given inputs (the heights of the mountains)
# and where you have to print an output (the index of the mountain to fire on)
# The inputs you are given are automatically updated according to your last actions.


# game loop
while True:
    mountainH = [int(input()) for _ in range(8)]
    max_height = max(mountainH)
    max_index = mountainH.index(max_height)
    
    print(max_index)
