public class PatrolState : ICharacterState
{
    public void HandleInput(Character character, string input)
    {
        if(input == "alerted")
        {
            Console.WriteLine("Enemy spotted, giving chase!");
            character.SetState(new ChaseState());
        }
    }

    public void Update(Character character)
    {

    }
}

