//TicTacToe Beta4
//Start again with 2D arrays

//declare & initialize
char[,] gameBoard = new Char[3,3];
char[] playerSymbol = new char[2]{'X','O'};
bool invalidMove = false; ;
int gameMarker = 0;

while (!invalidMove) // invalid move if square occupied
{
    PlayerInput:
    Console.WriteLine("Please enter where you want to play along X axis");
    int playerChoiceX = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter where you want to play along Y axis");
    int playerChoiceY = Convert.ToInt32(Console.ReadLine());
    
    if (gameBoard [playerChoiceX,playerChoiceY] == 'X' || gameBoard [playerChoiceX,playerChoiceY] == 'O')
    {
        Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    else
    {
        gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[0];
    }
    DrawBoard();


}


gameBoard[1,1] = 'X';//Test !!!!!
DrawBoard();

//Drawboard
void DrawBoard()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"[2] {gameBoard[0,2]} | {gameBoard[1,2]} | {gameBoard[2,2]}");
    Console.WriteLine("    - + - + -");
    Console.WriteLine($"[1] {gameBoard[0,1]} | {gameBoard[1,1]} | {gameBoard[2,1]}");
    Console.WriteLine("    - + - + - ");
    Console.WriteLine($"[0] {gameBoard[0,0]} | {gameBoard[1,0]} | {gameBoard[2,0]}");
    Console.WriteLine("   [0] [1] [2]");
}