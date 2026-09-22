# Development log of shooter microgame

## 22/09/26
    
### Problem
Player movement wasn't working correctly, this is because speed would stack on the update loop. 

### Solution
Fix was moving the speed reset line inside of the loop

### Additions to the game
Player movement + FPS camera controls added