Console.WriteLine("Tic Tac Toe Beta");

Main();

void Main()
{
    int[] board = new int[9];
    board[0] = 5;
    board[1] = 5;
    board[2] = 5;
    board[3] = 5;
    board[4] = 5;
    board[5] = 5;
    board[6] = 5;
    board[7] = 5;
    board[8] = 5;

    int userTurn = -1;
    int aiTurn = -1;
    Random randomNum = new Random();



    while (CheckForWinner() == 0)
    {
        //PrintBoard();
        //check if cell already occupied
        while (userTurn == -1 || board[userTurn] != 5)
        {
            Console.WriteLine("Please enter a number from 0 to 8");
            userTurn = int.Parse(Console.ReadLine());
            Console.WriteLine("You typed " + userTurn);
        }

        board[userTurn] = 10;

        //check if cell already occupied
        while (aiTurn == -1 || board[aiTurn] != 5)
        {
            aiTurn = randomNum.Next(8);
            Console.WriteLine("AI chooses " + aiTurn);
        }

        board[aiTurn] = 0;
        PrintBoard();
    }
    
    int CheckForWinner()
    {
        //check for winner. return 0 for no winner, 1 for player 1, 2 for player 2 or ai
        //top row
        if (board[0] == board[1] && board[1] == board[2])
        {
            return board[0];
        }
        //middle row
        if (board[3] == board[4] && board[4] == board[5])
        {
            return board[3];
        }
        //bottom row
        if (board[6] == board[7] && board[7] == board[8])
        {
            return board[6];
        }
        //1st Column
        if (board[0] == board[3] && board[3] == board[6])
        {
            return board[0];
        }
        //2nd Colum
        if (board[1] == board[4] && board[4] == board[7])
        {
            return board[1];
        }
        //3rd Column
        if (board[2] == board[5] && board[5] == board[8])
        {
            return board[6];
        }
        //1st Diagonal
        if (board[0] == board[4] && board[4] == board[8])
        {
            return board[0];
        }
        //2nd Diagonal
        if (board[2] == board[4] && board[4] == board[6])
        {
            return board[2];
        }
        
        return 0;
    }
    
    void PrintBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            //check value of each cell, print corresponding string
            if (board[i] == 5)
            {
                Console.Write(".");
            }
            if (board[i] == 10)
            {
                Console.Write("X");
            }
            if (board[i] == 0)
            {
                Console.Write("O");
            }

            //Print 3 characters a line
            if (i == 2 || i == 5 || i == 8)
            {
                Console.WriteLine();
            }
        }
    }
}
