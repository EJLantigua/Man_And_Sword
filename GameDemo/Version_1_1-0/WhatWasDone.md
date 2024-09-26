# Man & Sword Version 1.1.0:

## --Controls of Player--
### Movement Direction:
* W Key - Move Up
* A Key - Move Left
* S Key - Move Down
* D Key - Move Right

* Left Mouse - Attack
* Left Mouse (Hold) - Continuous Attacking

* Movement Direction + SpaceBar - Dash 

## --What Was Done In This Version--
* - Added a sword animation with required scripting for the animation to rotate in the x, y, and z coordinate to the player object using Unity's Quaternion.Euler API for the swing of the sword
* - Wrote code to activate the attack and use the animation that was created with the Unity Built in Animation feature.
* - Wrote code to flip animations and character to face the appropriate direction depending on the mouse cursor to the player's left or right side.
* - Utilized IEnumerator variables to yield wait times to limit spamming attacks and time Animation object types
* - Wrote code to lower Enemy Health and Destroy GameObjects (if Enemy dies, end of animations)
* - Incorporated a dash function to the user that speeds the character up for a certain amount of time with a cooldown.

