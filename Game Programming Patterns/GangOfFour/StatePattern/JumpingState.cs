public class JumpingState : IHeroState
{
    public void HandleInput(Hero hero, string input)
    {
        if (input == "land")
            hero.SetState(new StandingState());
    }

    public void Update(Hero hero)
    {
        // handle jumping logic
    }
}

