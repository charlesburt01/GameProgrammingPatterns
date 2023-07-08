public class Hero
{
    private IHeroState _state;

    public Hero()
    {
        _state = new StandingState();
    }

    public void SetState(IHeroState state)
    {
        _state = state;
    }

    public void HandleInput(string input)
    {
        _state.HandleInput(this, input);
    }

    public void Update()
    {
        _state.Update(this);
    }

    public IHeroState GetState()
    {
        return _state;
    }
}

