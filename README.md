# Dead_and_Injured_WinForm by Ibrahim Adedokun

This is a Windows based game which requires 2 players. The game is all about guessing each other's secret numbers chosen from the start of the game.
//---------------------------------FIRST ROUND--------------------------
For example, at the start of the game if Player A chooses 1234 as his secret digits (unknown to Player B) and Player B chooses 6789 as his secret digits (also unkown to Player B). These numbers won't change.
//---------------------------------SECOND ROUND-------------------------
Player A predicts 4567: the output would be 0 dead, 2 injured
Player B predicts 1243: the output would be 2 dead, 2 injured
//---------------------------------THIRD ROUND--------------------------
Player A predicts 7689: the output would be Eureka! (4 dead).
This means the game is over.

PATTERN OF THE GAME
-For every digit predicted correctly in its actual position, it's counted as DEAD
-For every digit predicted among the opponent's secret digits but not in the actual position, it's counted as INJURED

***Also, repetition of digits are not allowed***
