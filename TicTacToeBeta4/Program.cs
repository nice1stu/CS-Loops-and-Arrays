//TicTacToe Beta4
bool validMove = true;
string player1Symbol = "X";
string player2Symbol = "O";
string[] cellSymbol = { "1", "X", "3", "4", "5", "6", "7", "8", "9" };

PlayerTurn();

void PlayerTurn()
{
    Console.WriteLine("Player selects where to play");
    while (validMove)
    {
        for (int i = 0; i < cellSymbol.Length; i++)
        {
            if (player1Symbol == cellSymbol [i])
            {
                validMove = false;
                Console.WriteLine("Move invalid, please select another position");
                PlayerTurn();
            }
        }


    }
}

//Invalid Move
void CheckInvalidMove()
{
    while (validMove)
    {
        for (int i = 0; i < cellSymbol.Length; i++)
        {
            if (player1Symbol == cellSymbol [i])
            {
                validMove = true;
                Console.WriteLine("Move invalid, please select another position");
                PlayerTurn();
            }
        }


    }

}
