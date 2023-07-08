public class RunningState : IHeroState
{
    public void HandleInput(Hero hero, string input)
    {
        if (input == "stop")
            hero.SetState(new StandingState());
        else if (input == "jump")
            hero.SetState(new JumpingState());
    }

    public void Update(Hero hero)
    {
        // handle running logic
    }
}


