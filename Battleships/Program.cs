Console.WriteLine("Lets try to make Battleship");

//declare arrays & variables
char[,] player1FleetMap = new char[9, 9];
char[,] player1AttackMap = new char[9, 9];
char[,] player2FleetMap = new char[9, 9];
char[,] player2AttackMap = new char[9, 9];

for (int x = 0; x < player1AttackMap.Length; x++)
{
    for (int y = 0; y < player1AttackMap.Length; y++)
    {
        player1AttackMap[x, y] = 'O';
    }
}

//draw maps
void Player1FleetMap()
{
    for (int x = 0; x < player1AttackMap.Length; x++)
    {
        for (int y = 0; y < player1AttackMap.Length; y++)
        {
            Console.Write(player1AttackMap[x,y]);
        }
        Console.WriteLine();
    }
}