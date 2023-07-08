public class Character
{
    private ICharacterState _state;

    public Character()
    {
        _state = new PatrolState();
    }
    public void HandleInput(string input)
    {
        _state.HandleInput(this, input);
    }
    public void Update()
    {
        _state.Update(this);
    }
    public void SetState(ICharacterState state) 
    {
        _state = state;
    }

    public ICharacterState GetState()
    {
        return _state;
    }
}

