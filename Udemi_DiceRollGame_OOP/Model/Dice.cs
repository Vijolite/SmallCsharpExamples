public class Dice
{
    private readonly Random _rnd;
    private const int SidesCount = 6;
    public int Value { get; private set; }

    public Dice(Random rnd)
    {
        _rnd = rnd;
    }

    public void Roll()
    {
        Value = _rnd.Next(1, SidesCount+1);  //from 1 till 6
    }
}