# Development log of shooter microgame

## 22/09/26

### Problem

Player movement wasn't working correctly, this is because speed would stack on the update loop.

### Solution

Fix was moving the speed reset line inside of the loop



## Another problem

The jump physics were weird and destroyed



## Solution

I researched the equation for vertical motion and integrated that into my script 



### Additions to the game

Player movement + FPS camera controls and gravity added

### Other things

Tested out pushes with Git; learned basics

## 23/06/26

### Additions to the game

Added a gun + bob and sway physics using a script I stole from a larger game I'm working on

## 24/09/26

### Problem

Bullets were spawning at the wrong co ordinates despite the script saying where to appear

### Solution

The bullet prefab had baked co ordinates into it. Debugged using debug.log to narrow down the problem until it was clear the script was working fine. Simply reset the prefab co ordinates to 0,0,0 and let the script have full manipulation

### Additions to the game

Bullet physics + shoot SFX

## 25/09/26

### Problem

Bullets weren't colliding with the drone prefab

### Solution

Added a box collider to the prefab (it didn't come with one for some reason)

### Another problem

Drone would always fly to the same spot

### Solution

The X and Z co ordinates were picking from a pool of random numbers from 20 to 20. It was always 20. I changed it to -20 to 20.

### Additions to the game

Killable enemy with autonomous movement + some SFX