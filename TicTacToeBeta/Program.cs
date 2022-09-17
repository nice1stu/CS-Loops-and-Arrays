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



    while (true)
    {
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

