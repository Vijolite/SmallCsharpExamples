public class Dice
{
    public int Value { get; private set; }

    public Dice()
    {

    }

    public void Roll()
    {
        Random rnd = new Random();
        Value = rnd.Next(1, 7);  //from 1 till 6
    }
}