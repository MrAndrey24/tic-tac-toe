# tic-tac-toe
This is a simple console-based implementation of the classic game Tic Tac Toe. The game is written in C# and runs on the .NET(7) . It allows two players to play against each other on the same computer.

# How to Play
When you start the game, you will see a 3x3 grid on the console. The two players take turns placing their symbol (X or O) on the grid by selecting a cell using the numbers 1-9. The first player to get three of their symbols in a row (horizontally, vertically, or diagonally) wins the game.

If all the cells are filled and no player has won, the game ends in a tie.

# Code Overview
The game is implemented using object-oriented programming principles in C#. The main game logic is contained in a while loop that continues until a player wins or the game ends in a tie. The program also uses various data structures such as lists, queues, and stacks to keep track of the state of the game.

The game logic includes checking for a winner on each turn, as well as preventing players from selecting a cell that has already been chosen. The program also includes the ability to undo the previous move using a stack data structure.
