# Tic Tac Toe Kata
## Requirements & Constraints
* The input to the solver function will be a collection with a length of 9, representing the board. The function’s output will be the index of the desired move (e.g. 7).
* The human player will always be represented by “O”, while the computer player will be represented by “X”.
* The input function should inform the player when an invalid input is entered (e.g. if the position is not empty, or etc)
* After each input, a render function should render the grid to screen containing the current state of the game.
* Users should be able to play as many rounds as they wish, without having to restart the application.

## Rules of the Game
### Game Play
* Two players are required for a game.
* Each player will assume wither an “X” or “O”.
* Players take turn to play till a player wins, or the end of the game (whichever happens first).

### Condition for a win
* A player wins when all fields in a column are taken by the player.
* A player wins when all fields in a row are taken by the player.
* A player wins when all fields in a diagonal are taken by the player.

### Conditions for end of Game
* The game is over when all fields are taken.