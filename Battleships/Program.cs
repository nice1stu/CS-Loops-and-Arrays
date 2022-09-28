/*2 Players
10 x 10 grid per player
Simplified Ship Sizes: Only 5x 1 sized ships
Players take alternating turns
Coordinates given in the form g7, a2, d2 etc...
consider using the numeric value of chars! :)
can be simplified at first with two inputs:
first: int x
then: int y
Feedback "Hit" or "Miss"
Win Condition: All enemy ships have been sunk
Bonus Rules (A*):
Ships: sizes 5, 4, 3, 2 ships with 2
Ships may be placed vertically or horizontally
Ships may not overlap and may not touch each other (i.e. there needs to be at least 1 empty grid cell around the ship in every direction)
Feedback "Ship sunk!"
Bonus Bonus (No score):
A.I.? :)
Radar Power Up
Can be used to detect ships in a 3x3 radius around the location placed (but not hit them)
Can you think of other power-ups? :)
Scanner Power Up
Can be used to scan a 3x3 radius around the location placed
Only returns "Ship detected" or "No ship detected"*/

Console.WriteLine("Lets try to make Battleship");

//declare arrays & variables
char[,] player1FleetMap = new char[9, 9];
char[,] player1AttackMap = new char[9, 9];
char[,] player2FleetMap = new char[9, 9];
char[,] player2AttackMap = new char[9, 9];

/*for (int x = 0; x < player1AttackMap.Length; x++)
{
    for (int y = 0; y < player1AttackMap.Length; y++)
    {
        player1AttackMap[x, y] = 'O';
    }
}*/
Maps();
//draw maps
void Maps()
{
    for (int x = 0; x < 10; x++)
    {
        for (int y = 0; y < 11; y++)
        {
            //Console.Write(player1AttackMap[x,y]);
            Console.Write("|");
            //Console.Write("__");//-1
        }
        Console.WriteLine();
    }
}