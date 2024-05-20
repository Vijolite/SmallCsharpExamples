public class Dice
{
    private readonly Random _rnd;
    public int Value { get; private set; }

    public Dice()
    {
        _rnd = new Random();
    }

    public void Roll()
    {
        Value = _rnd.Next(1, 7);  //from 1 till 6
    }
}