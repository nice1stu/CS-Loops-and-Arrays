Console.WriteLine("Tic Tac Toe Beta 2");
Main(args);
void Main(string[] args)
{
    int currentPlayer = -1;
    char[] gameMarkers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    
    do
    {
        currentPlayer = GetNextPlayer(currentPlayer);
        
        
        Instructions(currentPlayer);
        DrawGameBoard(gameMarkers);
    
        string userInput = Console.ReadLine();
    
        Console.Clear();
        
    } while (true);


    
    //3.  as user places markers on game update the board and notify which player turn
    //3.1 after each turn determine if won
    //3.2 if no winner back to step 1
    //3.3 if all markers placed and no winner, its draw stop game
    //3.4 if winner, announce who won and stop game
}

static void Instructions(int playerNumber)
{
    //1.  Provide instructions
    //1.1 greeting
    Console.WriteLine("--Welcome to Tic Tac Toe--");
    //1.2 Display Player symbols (X / O)
    Console.WriteLine("Player 1 : X");
    Console.WriteLine("Player 2 : O");
    Console.WriteLine();
    //1.3 Who's turn is it
    //1.4 instruct player to enter number 1 - 9
    Console.WriteLine($"Player {playerNumber} to move, select 1 - 9 on the gameboard");
    Console.WriteLine();
}

static void DrawGameBoard(char[] gameMarkers)
{
    //2.  Draw game board
    //2.1 Game will have 3 row & 3 columns numbered 1 - 9

    Console.WriteLine($" {gameMarkers[6]} | {gameMarkers[7]} | {gameMarkers[8]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameMarkers[3]} | {gameMarkers[4]} | {gameMarkers[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameMarkers[0]} | {gameMarkers[1]} | {gameMarkers[2]} ");

}

static int GetNextPlayer(int player)
{
    if (player.Equals(1))
    {
        return 2;
    }
    return 1;
}
