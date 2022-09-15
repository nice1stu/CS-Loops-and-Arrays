// the const keyword makes it so the values assigned to the
// variables cannot be changed during runtime
// this makes it more obvious, that these are configuration variables

using System.Numerics;
using System.Threading.Tasks.Dataflow;

const int deltaTimeMs = 1000 / 30;
const float deltaTime = deltaTimeMs / 1000f;
const int width = 30; // Change, if you like :)
const float animationDuration = 1f; // Change, if you like :)
float start = 0f;
float end = width;
float position = start;
float timePassed = 0f;

// TODO: Implement the missing functions here :)
float Lerp(float start, float end, float timePassed)
{
    position = start + ((end - start) * animationDuration);
    return position;
}

int RoundToInt(float position)
{
    position = MathF.Round(position);
    return position;
}


void Update()
{
    // we increase the passedTime by deltaTime
    // we divide the deltaTime by animationDuration
    // this causes time to reach value 1 (the end) within 1 seconds for 1 second duration
    // but in half the time (two seconds) if passing in 2 seconds for duration
    timePassed += deltaTime / animationDuration;
    // lerp will linearly interpolate the position between start and end
    // for value 0, it will be at start, for value 1, it will be at end
    // for value 0.5, it will be in the middle
    position = Lerp(start, end, timePassed);
    if (timePassed > 1f)
    {   // bounce back:
        // we set start to become end and end to become start:
        // ADVANCED: in case you're wondering, the technique used here are called ValueTuples
        (start, end) = (end, start);
        // we reset the timePassed, so it begins the animation
        timePassed = 0;
    }
}

void Render()
{
    // we need to find out the closest position for the player
    // e.g. the player might be at position 2.3f
    // in that case, we want to render him at dash number 2.
    int closestIndex = RoundToInt(position);
    Console.Write('|');
    for (int i = 0; i <= width; i++)
    {
        Console.Write(i == closestIndex ? 'O' : '-');
    }
    Console.WriteLine('|');
}

// A very typical game loop:
GameLoop:
Console.SetCursorPosition(0, 0); // first, we reset the cursor
Update(); // then, we update all of our game objects
Render(); // then, we render everything to the screen
Thread.Sleep(deltaTimeMs); // 30FPS is enough for us :)
goto GameLoop;
