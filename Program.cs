// Create a list to represent the game board
List<char> board = new List<char>();
for (int i = 0; i < 9; i++)
{
    board.Add(' ');
}

// Create a queue to keep track of moves made
Queue<int> moves = new Queue<int>();

// Create a stack to undo moves made
Stack<int> undoMoves = new Stack<int>();

// Create a variable to keep track of the current player
char currentPlayer = 'X';

// Create an infinite loop that will run until the game ends
while (true)
{
    // Display the current board
    Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);

    // Ask the current player to select a square
    Console.WriteLine("It's {0}'s turn. Select a square (1-9):", currentPlayer);
    int selectedSquare = int.Parse(Console.ReadLine()) - 1;

    // Check if the selected square is already occupied
    if (board[selectedSquare] != ' ')
    {
        Console.WriteLine("That square is already occupied. Please select another one.");
        continue;
    }

    // Make the move
    board[selectedSquare] = currentPlayer;
    moves.Enqueue(selectedSquare);
    undoMoves.Clear();

    int occupiedSquares = 0; // Initialize the occupied squares counter

    // Check if the current player has won
    if ((board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) ||
        (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) ||
        (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) ||
        (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) ||
        (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) ||
        (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) ||
        (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
        (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer))
    {
        Console.WriteLine("Player {0} has won!", currentPlayer);
        break;
    }
    else
    {
        // Count the number of occupied squares
        foreach (char c in board)
        {
            if (c != ' ')
            {
                occupiedSquares++;
            }
        }
        // Check if there is no winner
        if (occupiedSquares == 9)
        {
            Console.WriteLine("There is no winner!");
            break;
        }
    }

    // Change the current player
    if (currentPlayer == 'X')
    {
        currentPlayer = 'O';
    }
    else
    {
        currentPlayer = 'X';
    }

}