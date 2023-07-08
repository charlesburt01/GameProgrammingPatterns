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

/*Console.WriteLine("Generating new character");
Character c1 = new Character();
Printer("Patrol", c1);
c1.HandleInput("alerted");
Printer("Chase", c1);

Console.WriteLine("\n");

Console.WriteLine("Generating another character and setting it to flee state");
Character c2 = new Character();
c2.SetState(new FleeState());
Printer("Flee", c2);

Console.WriteLine("\n");

Console.WriteLine("Checking to see if first character is still in correct state");

Console.WriteLine("\n");

Printer("Chase", c1);

Console.WriteLine("\n");

Console.WriteLine("As you can see, it works with multiple characters");


void Printer(string expectedState, Character h)
{
    Console.WriteLine
        (
        "Expected state = " + expectedState +
        "State. Actual State = " + h.GetState()
        );
}*/