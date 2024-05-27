using Udemi_DiceRollGame_OOP.Model;

namespace Udemi_DiceRollGame_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var dice = new Dice(rnd);
            var game = new Game(dice);
            var result = game.Play();
            game.PrintResult(result);
            Console.ReadLine();
        }
    }
}

