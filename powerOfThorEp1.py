# Power of Thor - Episode 1

light_x, light_y, initial_tx, initial_ty = [int(i) for i in input().split()]

thor_x, thor_y = initial_tx, initial_ty

# game loop
while 1:
    remaining_turns = int(input())
    
    direction_x = ""
    direction_y = ""
    
    if thor_x > light_x:
        direction_x = "W"
        thor_x -= 1
    elif thor_x < light_x:
        direction_x = "E"
        thor_x += 1
        
    if thor_y > light_y:
        direction_y = "N"
        thor_y -= 1
    elif thor_y < light_y:
        direction_y = "S"
        thor_y += 1
    
    # A single line providing the move to be made: N NE E SE S SW W or NW
    print(direction_y + direction_x)



# MY CODE:
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