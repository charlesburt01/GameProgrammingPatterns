public class StandingState : IHeroState
{
    public void HandleInput(Hero hero, string input)
    {
        if (input == "run")
            hero.SetState(new RunningState());
        else if (input == "jump")
            hero.SetState(new JumpingState());
    }

    public void Update(Hero hero)
    {
        // handle standing logic
    }
}

