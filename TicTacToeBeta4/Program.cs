//TicTacToe Beta4
bool invalidMove = false;

//Invalid Move
void CheckInvalidMove()
{
    while (invalidMove)
    {
        if (playerSymbol == cellSymbol [i])
        {
            invalidMove = true;
            Console.WriteLine("Move invalid, please select another position");
            PlayerMove();
        }

    }

}
