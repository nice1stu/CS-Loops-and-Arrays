
void MoveForward()
{
    Console.WriteLine("Move Forward.");
}

void TurnRight()
{
    Console.WriteLine("Turn Right.");
}

void TurnLeft()
{
    TurnRight();
    TurnRight();
    TurnRight();
}

void TurnAround()
{
    TurnRight();
    TurnRight();
}

void ThreeSteps()
{
    MoveForward();
    MoveForward();
    MoveForward();
}

ThreeSteps();
TurnAround();
ThreeSteps();
TurnLeft();
ThreeSteps();
TurnLeft();
MoveForward();
TurnAround();
MoveForward();
