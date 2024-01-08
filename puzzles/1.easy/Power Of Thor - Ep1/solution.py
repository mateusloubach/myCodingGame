#Power Of Thor Ep1 - solution in Python

import sys
import math

# light_x: the X position of the light of power
# light_y: the Y position of the light of power
# initial_tx: Thor's starting X position
# initial_ty: Thor's starting Y position

light_x, light_y, initial_tx, initial_ty = [int(i) for i in input().split()]

# game loop
while True:
    # Read the number of remaining moves (not used in this example)
    remaining_turns = int(input())

    # Calculate the direction for Thor to move
    direction_x = ""
    direction_y = ""

    if initial_tx > light_x:
        direction_x += "W"
        initial_tx -=1
    elif initial_tx < light_x:
        direction_x += "E"
        initial_tx +=1

    if initial_ty > light_y:
        direction_y += "N"
        initial_ty -=1
    elif initial_ty < light_y:
        direction_y += "S"
        initial_ty +=1

    # Print the move instruction
    print(direction_y + direction_x)