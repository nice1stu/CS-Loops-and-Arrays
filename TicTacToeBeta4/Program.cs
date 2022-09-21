//TicTacToe Beta4
bool validMove = true;
string player1Symbol = "X";
string player2Symbol = "O";
string[] cellSymbol = { "1", "X", "3", "4", "5", "6", "7", "8", "9" };
string playerChoice;

PlayerTurn();

void PlayerTurn()
{
    Console.WriteLine("Select the number where you want to play X");
    playerChoice = Console.ReadLine();
    while (validMove)
    {
        for (int j = 0; j < cellSymbol.Length; j++)
        {
            if (player1Symbol == cellSymbol [j])
            {
                validMove = false;
                Console.WriteLine("Move invalid, please select another position");
                PlayerTurn();
            }
        }


    }
}
