
Bird Hawk = new Bird(new FastFyerBehaviour());
Bird Crow = new Bird(new NormalFlyBehaviour());
Bird Ostrich = new Bird();

Crow.FlyingBehaviour.Fly();
Hawk.FlyingBehaviour.Fly();
Ostrich.FlyingBehaviour.Fly();

public class Bird
{
    public IFly FlyingBehaviour;
    public Bird(IFly? flyingBehaviour = null)
    {
        FlyingBehaviour = flyingBehaviour ?? new NoFlyBehaviour();
    }
}
public interface IFly
{
    public void Fly();
}

public class FastFyerBehaviour : IFly
{
    public void Fly()
    {
        Console.WriteLine("I'm the FastFyerBehaviour, I fly fast!");
    }
}
public class NormalFlyBehaviour : IFly
{
    public void Fly()
    {
        Console.WriteLine("I'm the NormalFlyBehaviour, I fly normally!");
    }
}

public class NoFlyBehaviour : IFly
{
    public void Fly()
    {
        Console.WriteLine("I'm the NoFlyBehaviour, I can't fly!");
    }
}