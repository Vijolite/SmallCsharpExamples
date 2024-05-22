using Udemi_DiceRollGame_OOP.Model;

namespace Udemi_DiceRollGame_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var result = game.Play();
            game.PrintResult(result);
            Console.ReadLine();
        }
    }
}

