//Copy contents into main program.cs 
Hero _h = new Hero();

Printer("Standing", _h);
_h.HandleInput("run");
Printer("Running", _h);
Console.WriteLine("Now we pass in an uncaught string");
_h.HandleInput("undefined");
Printer("Running", _h);

Console.WriteLine("\n");

Hero _h2 = new Hero();

Printer("Standing", _h2);
_h2.SetState(new JumpingState());
Printer("Jumping", _h2);



void Printer(string expectedState, Hero h)
{
    Console.WriteLine
        (
        "Expected state = " + expectedState +
        "State. Actual State = " + h.GetState()
        );
}